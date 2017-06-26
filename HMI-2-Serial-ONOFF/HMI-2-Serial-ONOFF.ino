/*
* Hazael Fernando Mojica García
* 25/June/2017
* HMI-2-Serial-ONOFF
*/

int pinLED = 2;

void setup() {
  Serial.begin(115200);
  pinMode(pinLED, OUTPUT);
}

void loop() {
  if(Serial.available()) {
    switch(Serial.read()) {
      case 'a':
        digitalWrite(pinLED, HIGH);
      break;
      
      case 'b':
        digitalWrite(pinLED, LOW);
      break;
    }
  }
}
