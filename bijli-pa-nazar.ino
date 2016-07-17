// the setup routine runs once when you press reset:
const long averageFactor = 500;
int ledPin = A1;
void setup() {
  // initialize serial communication at 9600 bits per second:
  Serial.begin(9600);
  pinMode(ledPin, OUTPUT);
}

// the loop routine runs over and over again forever:
void loop() {
  // read the input on analog pin 0:
  long voltage = 0;
  double aVoltage = 0;

  digitalWrite(ledPin, HIGH);
  for(int j = 0;j <15; j++)
  {//stablizing   
  for(int i = 0; i <averageFactor; i++)
    {//averaging
    int sensorValue = analogRead(A0);
    // Convert the analog reading (which goes from 0 - 1023) to a voltage (0 - 5V):
    voltage += sensorValue ;//* (5.0 / 1023.0);
    }
    voltage = voltage/(averageFactor/58);
    aVoltage += voltage;
    digitalWrite(ledPin, LOW);
  }
  aVoltage /= 15;
  aVoltage /= 1000;
  //delay(1000);
  // print out the value you read:
  Serial.println(aVoltage);
}
