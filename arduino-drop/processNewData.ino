
/*
****************************************
* Function processNewData() 
* 
* Commands are dealt with as they are received. 
* Drop data is copied to variables and processed later.
* 
* [D123/B1/256/D2/]
* 
* 
*/


void processNewData()  
{

          Serial.println("start process");

          // HELLO message
          if (strcmp(receivedChars, "HELLO")  == 0)
          {
               // send a HELLO message back to the controller app
               Serial.print("[HELLO]");
               BTserial.print("[HELLO]");
  
              // turn off the flashing LED to show we are connected
              digitalWrite(LED_WAITING_PIN, HIGH); 
              waiting = false;
              receivedChars[0] = '\0';
          }

          
          
           // BYE message
          if (strcmp(receivedChars, "BYE")  == 0)
          {
                   // turn on the flashing LED to show we are no longer connected
                   digitalWrite(LED_WAITING_PIN, LOW); 
                   waiting = true;
                   receivedChars[0] = '\0';
          }         
           

           
          // Firmware version
          if (strcmp(receivedChars, "VERSION")  == 0)
          {
                   Serial.print("[V,");   Serial.print(versionNumber);    Serial.print(",");    Serial.print(compileDate);    Serial.print("]");
                   BTserial.print("[V,"); BTserial.print(versionNumber);  BTserial.print(",");  BTserial.print(compileDate);  BTserial.print("]");
                   receivedChars[0] = '\0';
          }              



         // Are You There
          if (strcmp(receivedChars, "AYT")  == 0)
          {
                   Serial.print("[YIA]");  
                   BTserial.print("[YIA]"); 
                   receivedChars[0] = '\0';
          }       


         // Start de drop sequence
          if (strcmp(receivedChars, "START")  == 0)
          {
                   printDebug("Run start");  
                    
                   receivedChars[0] = '\0';
                   if (haveNewData == false){
                    runSequence();
                   }
          }
           
          // Drain Valve
          // O11 - Valve 1 open    O10 - Valve 1 close
          if ( receivedChars[0] == 'O'   )
          {        
                   byte valve = receivedChars[1] - 48;  //  -48 converts an ascii "1" in to the value 1
                   byte flag =  receivedChars[2] - 48;
                   byte valvePIN = 0;
                   switch (valve) {
                    case 1 : 
                      valvePIN = 7;
                      break;
                    case 2 : 
                      valvePIN = 6;
                      break;
                    case 3 : 
                      valvePIN = 5;
                      break;
                    case 4 : 
                      valvePIN = 4;
                      break;
                   }

                   if (valve >0 && valve < 7)
                   {
                        // open valve
                        if (flag == 1) {  digitalWrite(valvePIN,HIGH);   }
                  
                        // close valve
                        if (flag == 0) {  digitalWrite(valvePIN,LOW);  }
                   }
                   receivedChars[0] = '\0';

          }   

          // Flash
          // F11 - Flash 1 open    F10 -Flash 1 close
          if ( receivedChars[0] == 'F'   )
          {  
                   byte flash = receivedChars[1] - 48;  //  -48 converts an ascii "1" in to the value 1
                   byte flag =  receivedChars[2] - 48;
                   byte flashPIN = 0;
                   switch (flash) {
                    case 1 : 
                      flashPIN = 10;
                      break;
                    case 2 : 
                      flashPIN = 9;
                      break;
                    case 3 : 
                      flashPIN = 8;
                      break;
                   }
                   if (flash >0 && flash < 7)
                   {
                        // flash ON
                        if (flag == 1) {  digitalWrite(flashPIN,HIGH);    }
                  
                        // flash OFF
                        if (flag == 0) {  digitalWrite(flashPIN,LOW);   }
                   }
                   receivedChars[0] = '\0';

          }  
         // Camera
          // C11 - Camera shutter on C10- Camera shutter off C21 Camera focus on C20 Camera focus off   
          if ( receivedChars[0] == 'C'   )
          {  
                   byte cameraFunc = receivedChars[1] - 48;  //  -48 converts an ascii "1" in to the value 1
                   byte ONOFF =  receivedChars[2] - 48;
                   byte PIN = 0;
                   if (cameraFunc == 1){
                    PIN = 12; //Camera shutter
                   } else { PIN = 11;} //Camera focus
                   if (ONOFF == 1) { digitalWrite(PIN, HIGH); }
                   else { digitalWrite(PIN, LOW); }
                   
                   receivedChars[0] = '\0';

          }  

    
      //Store the new sequence into variables
      if ( receivedChars[0] == 'D'   ) 
          {  
                  printDebug("RECIEVED NEW DATA"); 
                  NBDrops = receivedChars[1] - 48;  
                  sequenceReset();
                  haveNewData = true;
                  digitalWrite(LED_WAITING_PIN, HIGH);
          }
            //Store the new sequence into variables
      if ( receivedChars[0] == 'X'   ) 
          {  
                  printDebug("RECIEVED NEW DATA"); 

                  if (haveNewData == true) { storeSequence();}
                  //storeSequence();
          }

} 
