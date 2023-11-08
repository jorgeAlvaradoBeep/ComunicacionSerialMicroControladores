char opc;
void setup() {
  // put your setup code here, to run once:
  pinMode(LED_BUILTIN, OUTPUT);
  digitalWrite(LED_BUILTIN, LOW);
  Serial.begin(9600);
}

void loop() {
  serialEvent();
  delay(50);
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
        digitalWrite(LED_BUILTIN, HIGH);
        break;
      case '1':
        digitalWrite(LED_BUILTIN, LOW);
        break;
    }
  }
}
