/*
  Hazael Fernando Mojica Garcia
  09/June/2017
  Last Edit: 30/June/2017
  Example: HMI-2-ArduinoIO-Multi
*/

int pinServo = 3;
int pinLED = 4;
int pinPush = 35
int pinPotA = 0;
int LEDState = 0;
int pushState = 0;

unsigned int intervalLED = 2000;
unsigned int intervalPush = 500;
unsigned int intervalServo = 100;

unsigned long pastMillisLED = 0;
unsigned long pastMillisServo = 0;
unsigned long pastMillisPush = 0;

unsigned long currentMillis = 0;

void setup() {
  pinMode(pinServo, OUTPUT);//PWM pin as output
  pinMode(pinLED, OUTPUT);
  pinMode(pinPush, INPUT);
}

void loop() {
  currentMillis = millis();
  
  if((currentMillis - pastMillisLED) >= intervalLED) {
    //This block will be executed each intervalLED ms
    blinkLED();
    pastMillisLED = currentMillis;
  }
  
  if((currentMillis - pastMillisServo) >= intervalServo) {
    //This block will be executed each intervalServo ms
    moveServo();
    intervalServo = currentMillis;
  }
  
  if((currentMillis - pastMillisPush) >= intervalPush) {
    //This block will be executed each intervalPush ms
    changeBlinkInterval();
    intervalPush = currentMillis;
  }
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
  int newPushState = digitalRead(pinPush);
  if(pushState && !newPushState) {
    //Change interval when the user
    //is no more pressing the button
    intervalLED -= 50;//Decrease 50ms
    if(intervalLED < 50) {
      intervalLED = 2000; //Reset the Interval
    }
  }
  pushState = newPushState;
}