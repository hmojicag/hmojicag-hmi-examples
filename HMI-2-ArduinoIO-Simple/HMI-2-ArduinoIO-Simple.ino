/*
  Hazael Fernando Mojica Garcia
  09/July/2017
  Example: HMI-2-ArduinoIO-Simple
*/

void setup() {
  pinMode(6, OUTPUT); // LED 1
  pinMode(7, OUTPUT); // LED 2
  pinMode(8, INPUT);  // PUSH BUTTON 1
  pinMode(9, INPUT);  // PUCH BUTTON 2
}

void loop() {
 if(digitalRead(8)) {
   //If Push Button 1 is pressed
   // Turn ON LED 1 and OFF LED 2
   digitalWrite(6, HIGH);
   digitalWrite(7, LOW);
 }
 
 if(digitalRead(9)) {
   //If Push Button 2 is pressed
   // Turn OFF LED 1 and ON LED 2
   digitalWrite(6, LOW);
   digitalWrite(7, HIGH);
 }
}
