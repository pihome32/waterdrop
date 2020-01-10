
/*
****************************************
* Function makeDrops
* controls the solenoid values to make the drops
*/


void makeDrops()
{

    // make sure all valves are closed
    digitalWrite(ST1_PIN, LOW);   
    digitalWrite(ST2_PIN, LOW);   
    digitalWrite(ST3_PIN, LOW);   
    digitalWrite(ST4_PIN, LOW);     
    digitalWrite(ST5_PIN, LOW);    
    digitalWrite(ST6_PIN, LOW);      

  
    boolean done    = false;
    boolean done2   = false;
    boolean aborted = false;    
    
    long unsigned seqStartTime = 0;  
    int unsigned loopCount = 0;

    boolean CamTriggered   = false;
    boolean camDone = false;
    boolean flash1_Triggered = false;
    boolean flash1_Done = false;
    boolean flash2_Triggered = false;
    boolean flash2_Done = false;
    boolean flash3_Triggered = false;
    boolean flash3_Done = false;
    
    boolean allDropsDone = false;
    
    byte currentDrop = 0;
    boolean dropped[10] = { false, false, false, false, false, false, false, false, false, false} ;
    boolean solOpen[10] = { false, false, false, false, false, false, false, false, false, false} ;
    
     
    

    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=
    startPos:
    //-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=

    // Abort was part of the original dropController sketch and was removed when I created the apps
    // I want to add it back but haven't figured out a nice way to implement it with the apps version.
    
    // if (checkButtonPress(false)==BUTTON_SELECT ) { aborted = true; } 
    // sometimes a goto is just what you need.
    // if (aborted) {goto endPos; }
           


 
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-   

    // start the drop sequence
    


 
    // activate mirror lockup
    if (ML_On && !aborted) 
    { 
         digitalWrite( CT_FOCUS_PIN,   HIGH );  
         digitalWrite( CT_SHUTTER_PIN, HIGH );  
         delay( CT_Pulse );  
         digitalWrite( CT_FOCUS_PIN,   LOW );  
         digitalWrite( CT_SHUTTER_PIN, LOW );
         
         done = false;
         long unsigned startTime = millis();
         while (startTime == millis())  // This makes sure we are starting at the beginning of a millisecond
         {;}
         startTime = millis();
         while (!done)
         {
            if (millis() - startTime >= mirrorLockupDelay ) { done = true;  }
         }

    }

    if (aborted)  {  goto endPos ;  }  





    CamTriggered = false;         camDone = false;
    flash1_Triggered = false;     flash1_Done = false;
    flash2_Triggered = false;     flash2_Done = false;
    flash3_Triggered = false;     flash3_Done = false;
    
    allDropsDone = true;


    // set the drops as not dropped
    // set the solenoid valve for each drop as not open
    for (int i=1; i<=9; i++)   { dropped[i] = false;  solOpen[i] = false; }

    

    if(! FT1_On )  { flash1_Triggered = true;   flash1_Done = true;    }
    if(! FT2_On )  { flash2_Triggered = true;   flash2_Done = true;    }
    if(! FT3_On )  { flash3_Triggered = true;   flash3_Done = true;    }
    if(! CT_On )   { CamTriggered = true;       camDone= true;    }



    // Bulb mode 
    if(blubMode)
    {
         
         
          // get the longest time. This used to close the shutter in bulb mode.
          unsigned long longestTime = 0;
          
          for ( int drop=1; drop <= numDrops; drop++)
          {
              if ( dropStopTime[drop]  > longestTime ) {  longestTime = dropStopTime[drop];   }
          }
          if ( FT1_Time_Stop > longestTime) { longestTime = FT1_Time_Stop; }
          if ( FT2_Time_Stop > longestTime) { longestTime = FT2_Time_Stop; }
          if ( FT3_Time_Stop > longestTime) { longestTime = FT3_Time_Stop; }
      
          CT_Time_Stop = longestTime + bulbPost;



            if(USB_DEBUG) 
           {
             Serial.println("");
             Serial.print("Longest = ");  Serial.println(longestTime);
             Serial.print("CT stop  = "); Serial.println(CT_Time_Stop);
           }
      
               
         digitalWrite(CT_FOCUS_PIN,    HIGH);  
         digitalWrite(CT_SHUTTER_PIN , HIGH);
         CamTriggered = true;
         delay(bulbPre);
     
    }


    

    //
    //   FROM THIS POINT KEEP EVERYTHING TO ESSENTIAL OPERATIONS ONLY
    //


    done=false;
    seqStartTime = millis(); 
    while (seqStartTime == millis())  // Make sure we are starting at the beginning of a millisecond
    {}
    seqStartTime = millis();
    
    while (!done)
    {
        if (!CamTriggered && !camDone)         { if (millis() - seqStartTime >= CT_Time_Start    )  { PORTB |=(1<< PORTB3);   PORTB |=(1<< PORTB4);   CamTriggered = true;    }     }
        if (!flash1_Triggered && !flash1_Done) { if (millis() - seqStartTime >= FT1_Time_Start   )  { PORTB |=(1<< PORTB2);    flash1_Triggered = true;  }     }
        if (!flash2_Triggered && !flash2_Done) { if (millis() - seqStartTime >= FT2_Time_Start   )  { PORTB |=(1<< PORTB1);    flash2_Triggered = true;  }     }
        if (!flash3_Triggered && !flash3_Done) { if (millis() - seqStartTime >= FT3_Time_Start   )  { PORTB |=(1<< PORTB0);    flash3_Triggered = true;  }     }
        
        // assume all drops are done  then check to see if any are not.
        allDropsDone = true;
        
        // loop through the drops and see if we need to start or stop the solenoids
        for ( currentDrop=1; currentDrop <= numDrops; currentDrop++)
        {
             if ( !dropped[currentDrop] && !solOpen[currentDrop] )  
             { 
                  if ( millis() - seqStartTime >= dropStartTime[currentDrop] )   { openSolenoid(  sol[currentDrop]);  solOpen[currentDrop] = true;     } 
             }  
             
             if (solOpen[currentDrop]) 
             { 
                  if ( millis() - seqStartTime >= dropStopTime[currentDrop]  )   
                  { 
                       closeSolenoid( sol[currentDrop] );  
                       solOpen[currentDrop] = false;   
                       dropped[currentDrop] = true; 
                  }   
             }
              
             if ( !dropped[currentDrop] ) { allDropsDone = false;}              
              
        } // for ( currentDrop=1; currentDrop < tmpNumDrops; currentDrop++)
        
        
        // check to see if need to stop the flash trigger or the camera triggers
        if (!flash1_Done) { if (flash1_Triggered && ( millis() - seqStartTime >= FT1_Time_Stop  ))  {  PORTB &=~ (1<<PORTB2);        flash1_Done = true;  }     }
        if (!flash2_Done) { if (flash2_Triggered && ( millis() - seqStartTime >= FT2_Time_Stop  ))  {  PORTB &=~ (1<<PORTB1);       flash2_Done = true;  }     }  
        if (!flash3_Done) { if (flash3_Triggered && ( millis() - seqStartTime >= FT3_Time_Stop  ))  {  PORTB &=~ (1<<PORTB0);       flash3_Done = true;  }     }
        if (!camDone)     { if (CamTriggered   &&   ( millis() - seqStartTime >= CT_Time_Stop ))    { PORTB &=~ (1<<PORTB3);  PORTB &=~ (1<<PORTB4);  camDone = true;  }    }
        
        if (allDropsDone && flash1_Done && flash2_Done && flash3_Done && camDone) {done = true;}
        
    } // while (!done)




    // at this point all drops and triggers should have been activated.

    // -=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-=-
  
    
    ;
    endPos:
    ;
    // close all 
    // left in as part of the abort. May reimplement an abort function later

    
    digitalWrite(CT_FOCUS_PIN,   LOW);  
	digitalWrite(CT_SHUTTER_PIN, LOW);

    digitalWrite(FT1_PIN, LOW);  
    digitalWrite(FT2_PIN, LOW);  
    digitalWrite(FT3_PIN, LOW);  
  
    digitalWrite(ST1_PIN, LOW);   
    digitalWrite(ST3_PIN, LOW);   
    digitalWrite(ST3_PIN, LOW);   
    digitalWrite(ST4_PIN, LOW);     
    digitalWrite(ST5_PIN, LOW);    
    digitalWrite(ST6_PIN, LOW);   


     
     
}   // void makeDrops()
