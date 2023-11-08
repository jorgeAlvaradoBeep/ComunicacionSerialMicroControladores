int ledPin = 13;
char opc;
void setup() {
  // put your setup code here, to run once:
  pinMode(ledPin, OUTPUT);
  digitalWrite(ledPin, LOW);
  Serial.begin(9600);
}

void loop() {
  delay(200);
}

void serialEvent() {
  while (Serial.available()) 
  {
    // Obtiene el nuevo byte:
    opc = (char)Serial.read();
    // Añade el nuevo byte a la cadena de entrada:
    switch (opc) 
    {
      case '0':
        digitalWrite(ledPin, HIGH);
        break;
      case '1':
        digitalWrite(ledPin, LOW);
        break;
    }
  }
}
