/*
*      _                      _____               _                _  _              
*     | |                    / ____|             | |              | || |            
*   __| | _ __  ___   _ __  | |      ___   _ __  | |_  _ __  ___  | || |  ___  _ __ 
*  / _` || '__|/ _ \ | '_ \ | |     / _ \ | '_ \ | __|| '__|/ _ \ | || | / _ \| '__| 
* | (_| || |  | (_) || |_) || |____| (_) || | | || |_ | |  | (_) || || ||  __/| |   
*  \__,_||_|   \___/ | .__/  \_____|\___/ |_| |_| \__||_|   \___/ |_||_| \___||_|      sketch_dropControllerV3_2019_005_03
*                    | |                                                                                                      
*                    |_|                                                                            
*
* By Martyn Currey.  www.dropController.com
*
* dropController, a device for controlling solenoid valves for creating water drop collisions
* Create up to 9 drops 
* 
* 1 x camera connection (shutter & focus)
* 3 x flash connection
* 6 x solenoid valve connections
* 
* Receives the controls and times from an Android app or a Windows program
* Connects via Bluetooth or USB.  
* 
* 
* For Future
* FT3 - digital trigger/input. I like the idea of using this to turn a light off and on when a drop sequence is active
* change to direct port manipulation
* 
* 

*
*
* 2018-08-18 beta release 
* 2019-02-07 minor update
* 2019-02-11 added !Serial for Leonardo & Micro
*            changed non-connected blink rate
* 2019-04-10 FT3
*            Bug fix: FT2 and FT3 triggered flag
* 
* 2019-08-01 No longer support sensors
*            reverted to a drop control device
* 
* 2019-10-11 receivedChars[0] = '\0';
*            change double quotes to single quotes
* 
* 
* 
* 
*   _____   _             
*  |  __ \ (_)            
*  | |__) | _  _ __   ___ 
*  |  ___/ | || '_ \ / __|
*  | |     | || | | |\__ \
*  |_|     |_||_| |_||___/
* Pins
* 02 - SOLENOID 6
* 03 - SOLENOID 5
* 04 - SOLENOID 4
* 05 - SOLENOID 3
* 06 - SOLENOID 2
* 07 - SOLENOID 1
* 08 - SPARE TRIGGER
* 09 - FLASH TRIGGER 2
* 10 - FLASH TRIGGER 1
* 11 - FOCUS
* 12 - SHUTTER
* 13 - 
* 14 A0 - LED - waiting
* 15 A1 - LED - ActiVe
* 16 A2 
* 17 A3 
* 18 A4 - SOFTWARE SERIAL TX
* 19 A5 - SOFTWARE SERIAL RX
* 20 A6
* 21 A7  
*
*
* 
*    _____                                                _      
*   / ____|                                              | |     
*  | |      ___   _ __ ___   _ __ ___    __ _  _ __    __| | ___ 
*  | |     / _ \ | '_ ` _ \ | '_ ` _ \  / _` || '_ \  / _` |/ __|
*  | |____| (_) || | | | | || | | | | || (_| || | | || (_| |\__ \
*   \_____|\___/ |_| |_| |_||_| |_| |_| \__,_||_| |_| \__,_||___/
* 
* expects the following data
* Sn                  - S = start of data marker. n = sequence number. Used for debugging.
* NDn                - n = number of drops. Used to check we have data for all drops.
* D1101000030        - D = Drop Data. Drop 1, Solenoid 1, start at 100ms, size 30ms
* D2202100025        - D = Drop Data. Drop 2, Solenoid 2, start at 210ms, size 25ms
* D3302350020        - D = Drop Data. Drop 3, Solenoid 3, start at 235ms, size 20ms
* 
* F1Y0222035          - F1 = Flash Trigger 1. Y = ON (N = OFF) Trigger the flash at 222ms. Keep the trigger active for 035ms.
* F2Y0540050          - F2 = Flash Trigger 1. Y = ON (N = OFF) Trigger the flash at 540ms. Keep the trigger active for 050ms.
* F3N                 - F3 = Flash Trigger 3. N=OFF. 
* 
* CN                 - CT off
* CB11112222         - Bulb mode. 1111 = pre sequence offset.  2222 = post sequence offset
* CY1111222          - CT   Y=ON  1111- trigger time.   2222 pulse time  
* 
* MN                 - M = Mirror Lock Up. N= NO.  
* MY1000             - M = Mirror Lock Up. Y= YES. 1000 = time in ms to wait after the mirror lock up trigger
* EOD                - EOD = End of Drop Data
* 
* V11                - Valve 1 open
* V10                - Valve 1 close
* V21                - Valve 2 open
* V20                - Valve 2 close
* V31                - Valve 3 open
* V30                - Valve 3 close
* 
* HELLO              - Connection request from the control app
* BYE                - connection closed by the control app
* VERSION            - request for firmware version. 
* AYT                - connection check - may not be used in all apps.
*
* 
*
*/


boolean USB_DEBUG = true;
// when true output debug information to the serial monitor via the usb connection
// For this to work the dropController has to be connected by Bluetooth.




#include <SoftwareSerial.h> 
SoftwareSerial BTserial(18, 19); // RX, TX
// I haven't used pin number variables


//#include <digitalIOPerformance.h>
// digitalIOPerformance
// https://github.com/projectgus/digitalIOPerformance
// This library is outdated and does not work with the new Arduino boards. However, it works for all the boards based around the 328P and similar.
// The Arduino is fairly slow at switching digital pins. The digitalIOperformance library speeds this up (as long as the pin numbers are stored as constants).

// I may remove this later and implement direct port addressing. This will limit the type of Arduinos that can be used.




// CONSTANTS *************************************************

// Version
const char versionNumber[] = "V3_2019_005_03";
const char fileName[] = __FILE__;
const char compileDate[] = __DATE__;


// Devices
const byte CAMERA   = 1;
const byte FOCUS    = 2;
//const byte FLASH1   = 3;  No longer used
//const byte FLASH2   = 4;
//const byte FLASH3   = 5;

// Pins
const byte AN_IN1_PIN            = A2;
const byte AN_IN2_PIN            = A3;

const byte SS_RX_PIN             = 17;
const byte SS_TX_PIN             = 16;

const byte LED_ACTIVE_PIN        = 15;
const byte LED_WAITING_PIN       = 14;

const byte CT_SHUTTER_PIN        = 12;
const byte CT_FOCUS_PIN          = 11;

const byte FT1_PIN               = 10;
const byte FT2_PIN               = 9;
const byte FT3_PIN               = 8;

const byte ST1_PIN               = 7; 
const byte ST2_PIN               = 6; 
const byte ST3_PIN               = 5; 
const byte ST4_PIN               = 4; 
const byte ST5_PIN               = 3; 
const byte ST6_PIN               = 2; 


unsigned int inCount = 0;



// drop data variables *************************************************

// mirrorLockup. When set will issue a pre-sequence shutter trigger to activate the mirror lockup on the camera. 
// The delay is how long to wait after the lock up. 
// The trigger pulse length is set by the camera trigger pulse value
boolean mirrorLockup           = false;
unsigned int mirrorLockupDelay = 0;

// Trigger duration
// These values are over-ridden by the data from the control app
unsigned int  camTriggerPulseDuration      = 50;        // How long the camera trigger signal is active
unsigned int  flashTriggerPulseDuration    = 50;        // How long the flash trigger is active. 


// Arrays to hold the drop times
// I don't use element [0]. This means drop 1 is at position [1] 
byte sol[10]                        = {0,1,1,1,1,1,1,1,1,1};      // the solenoid to use for the drop; 1 to 6
unsigned int dropStartTime[10]      = {0,0,0,0,0,0,0,0,0,0};      // start time in millisecond 
unsigned int dropStopTime[10]       = {0,0,0,0,0,0,0,0,0,0};      // stop time in millisecond 


unsigned int FT1_Time_Start  = 0;
unsigned int FT1_Time_Stop   = 0;
unsigned int FT2_Time_Start  = 0;
unsigned int FT2_Time_Stop   = 0;
unsigned int FT3_Time_Start  = 0;
unsigned int FT3_Time_Stop   = 0;
unsigned int CT_Time_Start   = 0;
unsigned int CT_Time_Stop    = 0;
unsigned int CT_Pulse        = 0;

boolean blubMode       = false;
unsigned long bulbPre  = 100;
unsigned long bulbPost = 100;

byte numDrops      = 0;
byte numDropsCheck = 0;

boolean waiting                 = true;
boolean wait_LED_State          = LOW;
unsigned long wait_timeNow      = 0;
unsigned long wait_timePrevious = 0;
unsigned long wait_delay        = 0;




// Variables used for receiving serial data  ************************************************
const byte numChars = 30;
char receivedChars[numChars];
boolean haveNewData = false;
boolean haveNewDrop = false;

// variables to hold received commands        ************************************************
char flashCommand1[20];
char flashCommand2[20];
char flashCommand3[20];
char cameraCommand[20];
char mirrLockupCommand[20];
char dropCommand[10][20] = {"0-1234567890", "1-1234567890", "2-1234567890" , "3-1234567890" , "4-1234567890" , "5-1234567890" , "6-1234567890" , "7-1234567890" , "8-1234567890" , "9-1234567890"    };

boolean FT1_On = false;
boolean FT2_On = false;
boolean FT3_On = false;
boolean CT_On  = false;
boolean ML_On  = false;


//  variables used when checking received data ************************************************
boolean haveFT1 = false;
boolean haveFT2 = false;
boolean haveFT3 = false;
boolean haveCT = false;
boolean haveML = false;
boolean haveAllDrops = false;



void setup() 
{

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


    
    BTserial.begin(9600);  


     
    // status LEDs
    pinMode(LED_WAITING_PIN,OUTPUT); digitalWrite(LED_WAITING_PIN, LOW); 
    pinMode(LED_ACTIVE_PIN,OUTPUT);  digitalWrite(LED_ACTIVE_PIN, LOW); 
  
    // define the trigger pins and set the pins to low
    pinMode(ST1_PIN, OUTPUT);    digitalWrite(ST1_PIN, LOW); 
    pinMode(ST2_PIN, OUTPUT);    digitalWrite(ST2_PIN, LOW); 
    pinMode(ST3_PIN, OUTPUT);    digitalWrite(ST3_PIN, LOW);
    pinMode(ST4_PIN, OUTPUT);    digitalWrite(ST4_PIN, LOW); 
    pinMode(ST5_PIN, OUTPUT);    digitalWrite(ST5_PIN, LOW); 
    pinMode(ST6_PIN, OUTPUT);    digitalWrite(ST6_PIN, LOW);    
    
    pinMode(CT_FOCUS_PIN,   OUTPUT);     digitalWrite(CT_FOCUS_PIN,   LOW); 
    pinMode(CT_SHUTTER_PIN, OUTPUT);     digitalWrite(CT_SHUTTER_PIN, LOW); 
    pinMode(FT1_PIN, OUTPUT);            digitalWrite(FT1_PIN, LOW);      
    pinMode(FT2_PIN, OUTPUT);            digitalWrite(FT2_PIN, LOW);    
    pinMode(FT3_PIN, OUTPUT);            digitalWrite(FT3_PIN, LOW);   

    initialise();

}






void loop() 
{
    // Serial.println(flashCommand1);
     recvWithStartEndMarkersUSB();
     recvWithStartEndMarkersBT(); 
     if (haveNewData) { processNewData(); }   //  copies received data to temp variables
                                              //  sets haveNewDrop to TRUE when it gets an "EOD" command. "EOD" is the End Of Data flag. 

      if(haveNewDrop)                       
      {      
           parseDropData();                   // copy the temp received data variables to the drop data arrays.
  
           if ( dropDataIsOK() )              // check we have all the drop data. This is a basic check only.
           {         
                 digitalWrite(LED_WAITING_PIN, LOW);
                 digitalWrite(LED_ACTIVE_PIN, HIGH);
                 makeDrops(); 
                 //delay(100);
                 sendFinishedFlag();
           }
           else 
           {    
                showError();
                reset();
           }
          
           digitalWrite(LED_WAITING_PIN, HIGH);
           digitalWrite(LED_ACTIVE_PIN,  LOW);
           initialise();
     }






     // WAITING just flashes the led
     // This version does not have a connected/!connected state. This means it will receive and process drop data even in the waitng state.     
     if (waiting)
     {
            wait_timeNow = millis();
            if (wait_timeNow - wait_timePrevious > wait_delay)
            {
                 wait_timePrevious = wait_timeNow;
                 if (wait_LED_State == LOW)   {  wait_LED_State = HIGH;    digitalWrite(LED_WAITING_PIN, HIGH);  wait_delay=100; }
                 else                         {  wait_LED_State = LOW;     digitalWrite(LED_WAITING_PIN, LOW);   wait_delay=900; }
            }
     }


        
    

}



/*
****************************************
* Function initialise
*/
void initialise()
{  
      numDrops = 0;
      numDropsCheck = 0;
      haveNewDrop  = false; 
      for (int i = 1; i < 10; i++)   {   dropCommand[i][0]=' ' ;  dropCommand[i][1]=0 ;      }
      haveFT1      = false;
      haveFT2      = false;
      haveFT3      = false;
      haveCT       = false;
      haveML       = false;
      haveAllDrops = false;
}




/*
****************************************
* Function reset
*/
void reset()
{
      // the control app waits for the finished flag. If this is not sent a timeout triggers in the app.
      sendFinishedFlag(); 
}




/*
****************************************
* Function dropDataIsOK
* checks the received drop data. Basic checking only.
*/
boolean dropDataIsOK()
{
      // I should expand this to check each field;   FT, CT, ML
      // and check to see if any drop data is blank
      
      boolean dataOK = true;
//      for (int i = 1; i < numDrops+1; i++)   
//      {  
//           if ( dropCommand[i][0]!='D')   {  dataOK = false;   }
//      }

      if (numDrops != numDropsCheck) { dataOK = false;  }
      if (dataOK == false) {            if (USB_DEBUG) {  Serial.println("[M,ERR: DD]");   }      }
      
      if (!haveFT1) { dataOK = false;   if (USB_DEBUG) {  Serial.println("[M,ERR: no FT1]"); }    } 
      if (!haveFT2) { dataOK = false;   if (USB_DEBUG) {  Serial.println("[M,ERR: no FT2]"); }    } 
      if (!haveFT3) { dataOK = false;   if (USB_DEBUG) {  Serial.println("[M,ERR: no FT3]"); }    } 
      if (!haveCT)  { dataOK = false;   if (USB_DEBUG) {  Serial.println("[M,ERR: no CT]"); }     } 
      if (!haveML)  { dataOK = false;   if (USB_DEBUG) {  Serial.println("[M,ERR: no ML]"); }     } 
     
      return dataOK;
      
}





/*
****************************************
* Function showError
* Flashes an LED to show there is an error.
*/
void showError()
{

    // may add the facility to show an error message in the app (Note to self: Use the popup message function from the BCP app).
    
    for (int i = 1; i < 10; i++) 
    {
        digitalWrite(LED_WAITING_PIN, HIGH);
        digitalWrite(LED_ACTIVE_PIN, LOW); 
        delay(50); 
        digitalWrite(LED_WAITING_PIN, LOW);
        digitalWrite(LED_ACTIVE_PIN, HIGH); 
        delay(50); 
    }
}







/*
****************************************
* Function sendFinishedFlag
* Empties any remaining serial data and sends a <FTS> signal
*/
void sendFinishedFlag()
{   
    char rc;
        while (Serial.available() > 0)    {  rc = Serial.read();   }  // not really required but makes me feel better.
        Serial.print("[FTS]");
        while (BTserial.available() > 0)  {  rc = BTserial.read(); }  // not really required but makes me feel better.
        BTserial.print("[FTS]");       


}
