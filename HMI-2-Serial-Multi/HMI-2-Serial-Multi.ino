/*
* Hazael Fernando Mojica García
* 25/June/2017
* HMI-2-Serial-Multi
*/

int pinServo = 3;
int pinLED = 4;
int pinPush = 5;
int pinPotA = 0;

int pwmVal = 0;

void setup() {
  Serial.begin(115200);
  pinMode(pinServo, OUTPUT);//PWM pin as output
  pinMode(pinLED, OUTPUT);
  pinMode(pinPush, INPUT);
}

void loop() {
  if(Serial.available()) {
    switch(Serial.read()) {
      case 'a'://Turn On LED
        setLEDval(1);
      break;
      
      case 'b'://Turn Off LED
        setLEDval(0);
      break;
      
      case 'c'://Increase servo PWM
        increaseServo();
      break;
      
      case 'd'://Decrease servo PWM
        decreaseServo();
      break;

      case 'e'://Read Digital Val
        readDigitalVal();
      break;

      case 'f'://Read Analog Value
        readAnalogVal();
      break;
    }
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

void increaseServo() {
  pwmVal += 10;
  if(pwmVal > 255) {
    pwmVal = 255;
  }
  setPWMVal();
}

void decreaseServo() {
  pwmVal -= 10;
  if(pwmVal < 0) {
    pwmVal = 0;
  }
  setPWMVal();
}

void setPWMVal() {
  analogWrite(pinServo, pwmVal);
  Serial.print("PWM val: ");
  Serial.println(pwmVal);
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
