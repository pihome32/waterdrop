
/*
****************************************
* Function parseDropData
* Converts ascii text to numeric values for the drop data, the flash trigger time, the camera shutter trigger time and the mirror lock up time 
* 
    send com = [SOD]
    send com = [ND4]
    send com = [D101000050]
    send com = [D202000050]
    send com = [D303000050]
    send com = [D404000050]
    send com = [MN]
    send com = [CY1111050]
    send com = [F1Y2222050]
    send com = [F2N]
    send com = [EOD]

*/

    

void parseDropData()
{
     unsigned int temp = 0;
     FT1_Time_Start = 0;
     FT1_Time_Stop = 0;
     FT2_Time_Start = 0;
     FT2_Time_Stop = 0;
     FT3_Time_Start = 0;
     FT3_Time_Stop = 0;     
     mirrorLockupDelay = 0; 
     
     
     bulbPre = 0;
     bulbPost = 0;
     blubMode = false;

     CT_Pulse = 0;
     CT_Time_Start = 0;
     CT_Time_Stop = 0;


     for (int i = 1; i < 10; i++)   
     {
         dropStartTime[i] = 0;
         dropStopTime[i] = 0;
     }





     // CT    [CN]   [CY0999050]  [CB01000100]   

     // [CN]
     if ( cameraCommand[1] == 'N')  {  CT_On = false; }  else {  CT_On = true; }


     //   [CY1234123]
     if ( cameraCommand[1] == 'Y')
     {
           temp =        (cameraCommand[2] - 48) * 1000;
           temp = temp + (cameraCommand[3] - 48) * 100;
           temp = temp + (cameraCommand[4] - 48) * 10;
           temp = temp +  cameraCommand[5] - 48;
           CT_Time_Start = temp;
           
           temp =        (cameraCommand[6] - 48) * 100;
           temp = temp + (cameraCommand[7] - 48) * 10;
           temp = temp +  cameraCommand[8] - 48;
  
           CT_Pulse = temp;
           CT_Time_Stop = CT_Time_Start + temp;

           CT_On = true;
           
           if(USB_DEBUG) 
           {
             Serial.println("");
             Serial.print("CT start = "); Serial.println(CT_Time_Start);
             Serial.print("CT stop  = "); Serial.println(CT_Time_Stop);
            
           }


           

     }


     //    2   6
     // [CB12341234]
     if ( cameraCommand[1] == 'B')
     {
           blubMode = true;
           
           // [CB02000200]
           temp =        (cameraCommand[2] - 48) * 1000;
           temp = temp + (cameraCommand[3] - 48) * 100;
           temp = temp + (cameraCommand[4] - 48) * 10;
           temp = temp +  cameraCommand[5] - 48;
           bulbPre = temp;
  
           temp =        (cameraCommand[6] - 48) * 1000;
           temp = temp + (cameraCommand[7] - 48) * 100;
           temp = temp + (cameraCommand[8] - 48) * 10;
           temp = temp +  cameraCommand[9] - 48;
           bulbPost = temp;

           CT_On = true;
    
     }




     
  
     // mirror Lock Up     [MY1000]    [MN]
     if (mirrLockupCommand[1] == 'N') 
     {
           ML_On = false;
           mirrorLockup = false;
     }
     else
     {
           mirrorLockup = true; 
           ML_On = true;
           temp =        (mirrLockupCommand[2] - 48) * 1000;
           temp = temp + (mirrLockupCommand[3] - 48) * 100;
           temp = temp + (mirrLockupCommand[4] - 48) * 10;
           temp = temp +  mirrLockupCommand[5] - 48; 
           mirrorLockupDelay = temp; 
     }
     






 
     //                0123456789     
     // FT1  [F1N]    [F1Y2222050] 


     // FT1
     if ( flashCommand1[2] == 'N')
     {
           FT1_On = false;
     }
     else
     {
           FT1_On = true;
           temp =        (flashCommand1[3] - 48) * 1000;
           temp = temp + (flashCommand1[4] - 48) * 100;
           temp = temp + (flashCommand1[5] - 48) * 10;
           temp = temp +  flashCommand1[6] - 48;
           FT1_Time_Start = temp;
   
                   
           temp =        (flashCommand1[7] - 48) * 100;
           temp = temp + (flashCommand1[8] - 48) *10;
           temp = temp + (flashCommand1[9] - 48);
           FT1_Time_Stop = FT1_Time_Start + temp;

           if(USB_DEBUG) 
           {
             Serial.println("");
             Serial.print("FT1 start = "); Serial.println(FT1_Time_Start);
             Serial.print("FT1 stop  = "); Serial.println(FT1_Time_Stop);
            
           }
           
      }


     
     //                0123456789     
     // FT2  [F2N]    [F2Y2222050] 

     // FT2
     if ( flashCommand2[2] == 'N')
     {
           FT2_On = false;
     }
     else
     {
           FT2_On = true;
           temp =        (flashCommand2[3] - 48) * 1000;
           temp = temp + (flashCommand2[4] - 48) * 100;
           temp = temp + (flashCommand2[5] - 48) * 10;
           temp = temp +  flashCommand2[6] - 48;
           FT2_Time_Start = temp;
           
           temp =        (flashCommand2[7] - 48) * 100;
           temp = temp + (flashCommand2[8] - 48) * 10;
           temp = temp + (flashCommand2[9] - 48);
           FT2_Time_Stop = FT2_Time_Start + temp;

           if(USB_DEBUG) 
           {
             Serial.println("");
             Serial.print("FT2 start = "); Serial.println(FT2_Time_Start);
             Serial.print("FT2 stop  = "); Serial.println(FT2_Time_Stop);
            
           }

           
     }

 
     //                0123456789     
     // FT3  [F3N]    [F3Y2222050] 

     // FT3
     if ( flashCommand3[2] == 'N')
     {
           FT3_On = false;
     }
     else
     {
           FT3_On = true;
           temp =        (flashCommand3[3] - 48) * 1000;
           temp = temp + (flashCommand3[4] - 48) * 100;
           temp = temp + (flashCommand3[5] - 48) * 10;
           temp = temp +  flashCommand3[6] - 48;
           FT3_Time_Start = temp;
           
           temp =        (flashCommand3[7] - 48) * 100;
           temp = temp + (flashCommand3[8] - 48) * 10;
           temp = temp + (flashCommand3[9] - 48);
           FT3_Time_Stop = FT3_Time_Start + temp;
           
           if(USB_DEBUG) 
           {
             Serial.println("");
             Serial.print("FT3 start = "); Serial.println(FT3_Time_Start);
             Serial.print("FT3 stop  = "); Serial.println(FT3_Time_Stop);
            
           }
     }


     

/*
 * drop data
 * 
 * [D1101000050]
 * [D2202000050]
 * [D3303000050]
 * [D4404000050]
 * 
 *  0 23   7  0
 * [D4404000050]
 */


     byte dropNumber = 0;
     
     for (int i = 1; i < numDrops+1; i++)   
     {   
         //  01234567890
         // [D1101000050]
         dropNumber      = dropCommand[i][1] - 48;
         sol[dropNumber] = dropCommand[i][2] - 48;
  
         temp =        (dropCommand[i][3] - 48) * 1000;
         temp = temp + (dropCommand[i][4] - 48) * 100;
         temp = temp + (dropCommand[i][5] - 48) * 10;
         temp = temp +  dropCommand[i][6] - 48;
         dropStartTime[dropNumber] = temp;
         
         temp =        (dropCommand[i][7] - 48) * 1000;
         temp = temp + (dropCommand[i][8] - 48) * 100;
         temp = temp + (dropCommand[i][9] - 48) * 10;
         temp = temp +  dropCommand[i][10] - 48;              
         dropStopTime[dropNumber] = dropStartTime[dropNumber] + temp;

    }




}


