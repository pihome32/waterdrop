
/*
****************************************
* Function processNewData() 
* 
* Commands are dealt with as they are received. 
* Drop data is copied to variables and processed later.
* 
*/


void processNewData()  
{


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




           
           
          // Drain Valve
          // O11 - Valve 1 open    O10 - Valve 1 close
          if ( receivedChars[0] == 'O'   )
          {  
                   byte valve = receivedChars[1] - 48;  //  -48 converts an ascii "1" in to the value 1
                   byte flag =  receivedChars[2] - 48;
                   
                   if (valve >0 && valve < 7)
                   {
                        // open valve
                        if (flag == 1) {  openSolenoid(valve);    }
                  
                        // close valve
                        if (flag == 0) {  closeSolenoid(valve);   }
                   }
                   receivedChars[0] = '\0';

          }   






//  For the drop commands. Copy to temp variables and parse the data later

          // NDx  Number of drops
          if (  receivedChars[0]=='N'  )
          {  
              numDropsCheck = receivedChars[1] - 48;
              receivedChars[0] = '\0';
          }


          // copy the drop data to dropCommand[]
          if (receivedChars[0]=='D') 
          {   
                   numDrops++;
                   strcpy(dropCommand[numDrops], receivedChars);
                   receivedChars[0] = '\0';
          }    




// copy the flash trigger commands

          
          if (receivedChars[0] == 'F' ) 
          {    
                 if (  receivedChars[1] =='1')  
                 {       
                    strcpy(flashCommand1, receivedChars);
                    haveFT1 = true;
                 }
                 else if (  receivedChars[1] =='2')
                 {
                    strcpy(flashCommand2, receivedChars);
                    haveFT2 = true;
                 }
                 else if (  receivedChars[1] =='3')
                 {
                    strcpy(flashCommand3, receivedChars);
                    haveFT3 = true;
                 }

                 receivedChars[0] = '\0';
          }



// copy the camera trigger command to cameraCommand[]
          if (receivedChars[0] == 'C'  ) 
          {  
                   strcpy(cameraCommand, receivedChars);
                   haveCT = true;
                   receivedChars[0] = '\0';
    
         }
                 





            
// copy the mirror lockup trigger command to mirrLockupCommand[]
          // MN1000                                                 
          if (receivedChars[0] == 'M'  ) 
          {  
                   strcpy(mirrLockupCommand, receivedChars);
                   haveML = true;
                   receivedChars[0] = '\0';
          }   


              
          // EOD  
          if (  (receivedChars[0]=='E') && (receivedChars[1]=='O') && (receivedChars[2]=='D')    )
          {  
                   haveNewDrop = true; 
                   receivedChars[0] = '\0';

          }

          haveNewData = false;  
          


} // void copyNewSerialData() 







