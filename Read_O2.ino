// Grove - Gas Sensor(O2) test code
// Note:
// 1. It need about about 5-10 minutes to preheat the sensor
// 2. modify VRefer if needed

//const float VRefer = 5;       // voltage of adc reference
const float VRefer = 5;
const int  pinAdc = A0;

void setup() 
{
    // put your setup code here, to run once:
    Serial.begin(9600);
//Serial.println("Grove - Gas Sensor Test Code...");
//Serial.println("");
    delay(1000);
}

void loop() 
{
    // put your main code here, to run repeatedly:
   // float Vout =0;
// Serial.print("O2");

  //  Vout = readO2Vout();
//  Serial.print(Vout);

    Serial.println(readConcentration());
   //Serial.println(" ");
    delay(1000);
}

float readO2Vout()
{
    long sum = 0;
    for(int i=0; i<32; i++)
    {
        sum += analogRead(pinAdc);
    }

    sum >>= 5;

    float MeasuredVout = sum * (VRefer / 1023.0);
    return MeasuredVout;
}

float readConcentration()
{
    // Vout samples are with reference to 3.3V
    float MeasuredVout = readO2Vout();

    //float Concentration = FmultiMap(MeasuredVout, VoutArray,O2ConArray, 6);
    //when its output voltage is 2.0V,
    float Concentration = MeasuredVout * 0.21 / 1.4;
    float Concentration_Percentage=Concentration*100;
    return Concentration_Percentage;
}
