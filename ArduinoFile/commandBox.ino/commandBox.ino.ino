#define LED 4
#define BUTTONTEST 7

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  pinMode(BUTTONTEST, INPUT_PULLUP);
}

void loop() {
  digitalWrite(LED, LOW);
  if (digitalRead(BUTTONTEST) == LOW)
  {
    Serial.println("do");
    digitalWrite(LED, HIGH);
    delay(1000);
  }
  delay(500);
}
