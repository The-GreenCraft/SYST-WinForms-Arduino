int intLEDPin = 13;
byte bytRec = 0;

void setup() {
  pinMode(intLEDPin, OUTPUT);
  Serial.begin(9600);

}

void loop() {
  if (Serial.available())
  {
    bytRec = Serial.read();
  }
  if (bytRec == 1)
  {
    digitalWrite(intLEDPin, HIGH);
  }
  else
  {
    digitalWrite(intLEDPin, LOW);
  }

}
