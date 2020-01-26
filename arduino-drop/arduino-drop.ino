
//[N1000B4,1500D7,1520D7,1605D7,1620D7,1700D7,1720D7,2013B2,2250B2,2500B4]

boolean USB_DEBUG = true;
// Version
const char versionNumber[] = "V1_2020_01_21";
const char fileName[] = __FILE__;
const char compileDate[] = __DATE__;

const byte LED_ACTIVE_PIN        = A0;
const byte LED_COM_PIN       = A1;

const byte CT_SHUTTER_PIN        = 12;
const byte CT_FOCUS_PIN          = 11;

const byte FT1_PIN               = 10;
const byte FT2_PIN               = 9;
const byte FT3_PIN               = 8;

const byte ST1_PIN               = 7; 
const byte ST2_PIN               = 6; 
const byte ST3_PIN               = 5; 
const byte ST4_PIN               = 4; 


// Variables used for receiving serial data  ************************************************
const byte numChars = 100;
char receivedChars[numChars];


char startMarker = '[';
char endMarker = ']';
byte bytesRecvd = 0;
byte dataRecvCount = 0;
boolean inBTProgress = false;
boolean allReceived = false;
char tempChars[numChars]; 


bool newData = false;


unsigned int sequenceMillis[20] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0} ; /*Table with all time data for the sequence*/
unsigned int sequencePortB[20]= {};
unsigned int sequencePortD[20]= {};
const int PortAddress[8]= {B0000000,B00000010,B00000100,B00001000,B00010000,B00100000,B01000000,B10000000};
byte NBsequence = 0;

#include <SoftwareSerial.h> 
//SoftwareSerial BTserial(18, 19); // RX, TX

void setup() {
    sequenceReset();
    Serial.begin(9600);
    
    // required for Leonardo and Micro
    while (!Serial) {;}
    if(USB_DEBUG) 
   {
     Serial.println("");
     Serial.println("dropController V3");  
     Serial.print("Ver   = "); Serial.println(versionNumber);
     Serial.print("File  = "); Serial.println(fileName);
     Serial.print("Date  = "); Serial.println(compileDate);     
     Serial.println("");
   }

    // BTserial.begin(9600); 



    // status LEDs
    digitalWrite(LED_ACTIVE_PIN, HIGH); 
        // status LEDs
    pinMode(LED_COM_PIN,OUTPUT); digitalWrite(LED_COM_PIN, LOW); 
    pinMode(LED_ACTIVE_PIN,OUTPUT);  digitalWrite(LED_ACTIVE_PIN, LOW); 
  
    // define the trigger pins and set the pins to low
    pinMode(ST1_PIN, OUTPUT);    digitalWrite(ST1_PIN, LOW); 
    pinMode(ST2_PIN, OUTPUT);    digitalWrite(ST2_PIN, LOW); 
    pinMode(ST3_PIN, OUTPUT);    digitalWrite(ST3_PIN, LOW);
    pinMode(ST4_PIN, OUTPUT);    digitalWrite(ST4_PIN, LOW); 

    
    pinMode(CT_FOCUS_PIN,   OUTPUT);     digitalWrite(CT_FOCUS_PIN,   LOW); 
    pinMode(CT_SHUTTER_PIN, OUTPUT);     digitalWrite(CT_SHUTTER_PIN, LOW); 
    pinMode(FT1_PIN, OUTPUT);            digitalWrite(FT1_PIN, LOW);      
    pinMode(FT2_PIN, OUTPUT);            digitalWrite(FT2_PIN, LOW);    
    pinMode(FT3_PIN, OUTPUT);            digitalWrite(FT3_PIN, LOW);  


}


void loop() {
     getSerialBT();
     if (inBTProgress == false) {digitalWrite(LED_COM_PIN, LOW);}
     else { digitalWrite(LED_COM_PIN, HIGH);} 
     if (newData == true) {
        strcpy(tempChars, receivedChars);
        Serial.println(receivedChars);
            // this temporary copy is necessary to protect the original data
            //   because strtok() used in parseData() replaces the commas with \0
       // parseData();
       // showParsedData();
        newData = false;
        processNewData();
    }

}
