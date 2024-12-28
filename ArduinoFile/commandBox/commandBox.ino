#define LED 4
#define BTN1 7
#define BTN2 6

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  pinMode(BTN1, INPUT_PULLUP);
  pinMode(BTN2, INPUT_PULLUP);
}

void loop() {
  digitalWrite(LED, LOW);
  if (digitalRead(BTN1) == LOW)
  {
    Serial.println("1");
    digitalWrite(LED, HIGH);
    delay(1000);
  }
  else if (digitalRead(BTN2) == LOW)
  {
    Serial.println("2");
    delay(1000);
  }
  delay(500);
}
