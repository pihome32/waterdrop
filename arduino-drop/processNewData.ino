
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

          // Flash
          // F11 - Valve 1 open    F10 - Valve 1 close
          if ( receivedChars[0] == 'F'   )
          {  
                   byte flash = receivedChars[1] - 48;  //  -48 converts an ascii "1" in to the value 1
                   byte flag =  receivedChars[2] - 48;

                   if (flash >0 && flash < 7)
                   {
                        // open valve
                        if (flag == 1) {  FlashON(flash);    }
                  
                        // close valve
                        if (flag == 0) {  FlashOFF(flash);   }
                   }
                   receivedChars[0] = '\0';

          }  


         // Are You There
          if (strcmp(receivedChars, "START")  == 0)
          {
                   Serial.print("Run start");  
                    
                   receivedChars[0] = '\0';
                   runSequence();
          }    

      if ( receivedChars[0] == 'D'   )
          {  
                   sequenceReset();
                   int len = strlen(receivedChars);
                   Serial.println(len);
                   
                   int start = 1;
                   int record = 0;
                   String temp;
                   boolean IStimeData = true;
                   String timeData ;
                   for (int i = 1; i <= len; i++) {
                      
                      if (receivedChars[i]!='/'){
                        temp = temp + String(receivedChars[i]);
                        
                      } else {
                          
                          if (IStimeData == true){
                            timeData = temp;
                            IStimeData = false;
                            BTserial.println(timeData.toInt());
                            sequenceMillis[record]=timeData.toInt();
                            
                          }else {

                            String port = temp.substring(0,1);
                            String add = temp.substring(1,1);
                            int change = PortAddress[add.toInt()];
                            
                            if (port=="B"){
                              sequencePortB[record]=sequencePortB[record-1] ^ change ;
                            } else { sequencePortD[record]=sequencePortD[record-1] ^ change ;}
                            IStimeData = true;
                            record = record + 1;
                          }
                        start=i+1;
                        Serial.println(temp);
                        temp="";
                        
                      }
                      

                   }
                   BTserial.println("--------------");
                   for (int i = 0; i < 10; i++) {
                      BTserial.println(sequenceMillis[i]);
                   }
                   for (int i = 0; i < 10; i++) {
                      BTserial.println(sequencePortD[i]);
                   } 
                   for (int i = 0; i < 10; i++) {
                      BTserial.println(sequencePortB[i]);
                   }         
                   receivedChars[0] = '\0';

          }   

} // void copyNewSerialData() [D234/B1/345/B3/]
