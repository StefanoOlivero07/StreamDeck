#define LED 4
// #define BTNONOFF 3
#define BTN1 12
#define BTN2 10
#define BTN3 8
#define BTN4 6
#define BTN5 13
#define BTN6 11
#define BTN7 9
#define BTN8 7

void setup() {
  Serial.begin(9600);
  pinMode(LED, OUTPUT);
  // pinMode(BTNONOFF, INPUT_PULLUP);
  pinMode(BTN1, INPUT_PULLUP);
  pinMode(BTN2, INPUT_PULLUP);
  pinMode(BTN3, INPUT_PULLUP);
  pinMode(BTN4, INPUT_PULLUP);
  pinMode(BTN5, INPUT_PULLUP);
  pinMode(BTN6, INPUT_PULLUP);
  pinMode(BTN7, INPUT_PULLUP);
  pinMode(BTN8, INPUT_PULLUP);
}

void loop() {
  digitalWrite(LED, LOW);

  // if (digitalRead(BTNONOFF) == LOW)
  // {
  //   Serial.println("acc");
  //   digitalWrite(LED, HIGH);
  //   delay(1000);
  // }
  if (digitalRead(BTN1) == LOW)
  {
    Serial.println("1");
    digitalWrite(LED, HIGH);
    // delay(1000);
  }
  else if (digitalRead(BTN2) == LOW)
  {
    Serial.println("2");
    digitalWrite(LED, HIGH);
    // delay(1000);
  }
  else if (digitalRead(BTN3) == LOW)
  {
    Serial.println("3");
    // delay(1000);
  }
  else if (digitalRead(BTN4) == LOW)
  {
    Serial.println("4");
    // delay(1000);
  }
  else if (digitalRead(BTN5) == LOW)
  {
    Serial.println("5");
    // delay(1000);
  }
  else if (digitalRead(BTN6) == LOW)
  {
    Serial.println("6");
    // delay(1000);
  }
  else if (digitalRead(BTN7) == LOW)
  {
    Serial.println("7");
    // delay(1000);
  }
  else if (digitalRead(BTN8) == LOW)
  {
    Serial.println("8");
    delay(1000);
  }
  delay(500);
}
