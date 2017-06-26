/*
  Hazael Fernando Mojica Garcia
  09/July/2017
  Example: HMI-2-ArduinoIO-Multi
*/

int pinServo = 3;
int pinLED = 4;
int pinPush = 5;
int pinPotA = 0;
int LEDState = 0;

void setup() {
  pinMode(pinServo, OUTPUT);//PWM pin as output
  pinMode(pinLED, OUTPUT);
  pinMode(pinPush, INPUT);
}

void loop() {

}

void blinkLED() {
  LEDState = 1 - LEDState;//Swap LED state
  digitalWrite(pinLED, LEDState);//Blink LED
}

void moveServo() {
  int potVal = analogRead(pinPotA);//potVal from 0 to 1023
  analogWrite(pinServo, potVal/4);//Output PWM from 0 to 255 
}

void changeBlinkInterval() {
  if(digitalRead(pinPush)) {
    intervalLED -= 100;//Decrease 100ms
    if(intervalLED <= 100) {
      intervalLED = 1000; //Reset the Interval
    }
  }
}
