/*
* Hazael Fernando Mojica García
* 11/August/2017
* HMI-3-Arduino-.Net-Ex2
*/

int pinServo = 3;
int pinLED = 4;
int pinPush = 5;
int pinPotA = 0;

int pwmVal = 0;

void setup() {
  Serial.begin(115200);
  pinMode(pinServo, OUTPUT);
  pinMode(pinLED, OUTPUT);
  pinMode(pinPush, INPUT);
}

void loop() {
  if(Serial.available()) {
    switch(Serial.read()) {
      case 'a'://Turn On LED
        digitalWrite(pinLED, HIGH);
      break;
      
      case 'b'://Turn Off LED
        digitalWrite(pinLED, LOW);
      break;
      
      case 'c'://Increase servo PWM
        increaseServo();
      break;
      
      case 'd'://Decrease servo PWM
        decreaseServo();
      break;

      case 'f'://Read Analog Value
        readAnalogVal();
      break;
    }
  }
}

void increaseServo() {
  pwmVal += 5;
  if(pwmVal > 255) {
    pwmVal = 255;
  }
  setPWMVal();
}

void decreaseServo() {
  pwmVal -= 5;
  if(pwmVal < 0) {
    pwmVal = 0;
  }
  setPWMVal();
}

void setPWMVal() {
  analogWrite(pinServo, pwmVal);
}

void readAnalogVal() {
  //Write a String of values representing a number
  //between 0 and 1023 and adds \r\n at the end
  //Example: "0\r\n", "20\r\n", "341\r\n", "1023\r\n",
  //https://www.arduino.cc/en/Serial/Println
  Serial.println(analogRead(pinPotA));
}
