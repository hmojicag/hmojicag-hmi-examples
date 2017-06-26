/*
* Hazael Fernando Mojica García
* 25/June/2017
* HMI-2-Serial-Stream
*/

int pinServo = 3;
int pinLED = 4;
int pinPush = 5;
int pinPotA = 0;

//A buffer to store the incoming serial data
String commandBuffer = "";
String valueBuffer = "";
int appendStatus = 0;      //0 No append
                           //1 Append to command
                           //2 Append to value

void setup() {
  Serial.begin(115200);
  pinMode(pinServo, OUTPUT);//PWM pin as output
  pinMode(pinLED, OUTPUT);
  pinMode(pinPush, INPUT);
}

void loop() {
  readSerialBuffer();
}

void readSerialBuffer() {
  if(Serial.available()) {    
    char character = Serial.read();
    if(character == '&') {
      //We got a & separator
      //Execute the last command in buffer if valid
      executeCommand();
      appendStatus = 1;
    } else if (character == '-') {
      appendStatus = 2;
    } else {
      append2Buffer(character);
    }
  }
}

void append2Buffer(char val2append) {
  if(appendStatus == 1) {
    commandBuffer += val2append;
  } else if (appendStatus == 2) {
    valueBuffer += val2append;
  }
}

void executeCommand() {
  int command = commandBuffer.toInt();
  int value = valueBuffer.toInt();
  executeCommandImpl(command, value);
  commandBuffer = "";
  valueBuffer = "";
}

void executeCommandImpl(int command, int value) {
  //By convention the command 0 is an invalid command
  switch(command) {
    case 1://set LED
      setLEDval(value);
    break;
    
    case 2://set servo PWM
      setPWMVal(value);
    break;
  
    case 3://Read Digital Val
      readDigitalVal();
    break;
  
    case 4://Read Analog Value
      readAnalogVal();
    break;
  }
}

void setLEDval(int stat) {
  if(stat) {
    digitalWrite(pinLED, HIGH);
    Serial.println("LED ON");
  } else {
    digitalWrite(pinLED, LOW);
    Serial.println("LED OFF");
  }
}

void setPWMVal(int val) {
  analogWrite(pinServo, val);
  Serial.print("PWM val: ");
  Serial.println(val);
}

void readDigitalVal() {
  if(digitalRead(pinPush)) {
    Serial.println("Push val: HIGH");
  } else {
    Serial.println("Push val: LOW");
  }
}

void readAnalogVal() {
  //analogRead(pinPotA) will return a value between
  //0 and 1023, dividing it by 4 we made it fit in 8 bits
  Serial.print("Analog val: ");
  Serial.println(analogRead(pinPotA)/4);
}
