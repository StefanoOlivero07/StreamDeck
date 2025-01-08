#define LED 4
#define BTNONOFF 3
#define BTN1 13
#define BTN2 12

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  pinMode(BTNONOFF, INPUT_PULLUP);
  pinMode(BTN1, INPUT_PULLUP);
  pinMode(BTN2, INPUT_PULLUP);
}

void loop() {
  digitalWrite(LED, LOW);

  if (digitalRead(BTNONOFF) == LOW)
  {
    Serial.println("acc");
    digitalWrite(LED, HIGH);
    delay(1000);
  }
  if (digitalRead(BTN1) == LOW)
  {
    Serial.println("1");
    digitalWrite(LED, HIGH);
    delay(1000);
  }
  else if (digitalRead(BTN2) == LOW)
  {
    Serial.println("2");
    digitalWrite(LED, HIGH);
    delay(1000);
  }
  delay(500);
}
