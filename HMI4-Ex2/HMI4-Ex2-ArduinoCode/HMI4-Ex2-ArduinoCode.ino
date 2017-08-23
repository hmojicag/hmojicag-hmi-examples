/*
* Hazael Fernando Mojica García
* 22/August/2017
* HMI-4-C#-Streams
* Open a Serial connection at 115200 bds
* Commands:
* 1 Set LED
* 2 Set PWM
* 3 Read Digital Val at pinPush
* 4 Read Analog val at pinPotA
* Commands should be send in the next format:
* &c-v&
* c is the command number
* v is the value for such command
* & is a separator
* For example: &1-1& will turn the LED ON while &1-0& will turn it off.
* &2-120&3-0& will set the PWM to 120 and return the digital status
* of the pin pinPush.
* You can concatenate as many commands as you want as long as you
* respect the format &c-v&
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
    Serial.print("led-HIGH&");
  } else {
    digitalWrite(pinLED, LOW);
    Serial.print("led-LOW&");
  }
}

void setPWMVal(int val) {
  analogWrite(pinServo, val);
  Serial.print("pwm-");
  Serial.print(val);
  Serial.print("&");
}

void readDigitalVal() {
  if(digitalRead(pinPush)) {
    Serial.print("digital-HIGH&");
  } else {
    Serial.print("digital-LOW&");
  }
}

void readAnalogVal() {
  Serial.print("analog-");
  Serial.print(analogRead(pinPotA));
  Serial.print("&");
}
