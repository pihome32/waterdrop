


//Clean all the sequence tables
void sequenceReset()
{
    for (int i = 0; i < 20; i++) {
        sequencePortB[i]=B000000;
        sequencePortD[i]=B00000000;
        sequenceMillis[i]=0;       
    }
  }


void printDebug(String data)
{
 if (USB_DEBUG == true){
   //BTserial.println(data);
   Serial.println(data);
 }
}

void storeSequence()
{
 int len = strlen(receivedChars);
                 
 String temp;

 NBsequence = 1;
 byte posLetter = 0;

 printDebug("STORE NEW DATA"); 
 
 sequenceReset();

  //Format : [N1000B4,30000D7]
 for (byte n = 1; n < sizeof(receivedChars); n++) {
      if (receivedChars[n] == ',') {
        NBsequence++;
        temp = "";

      }
      else if (receivedChars[n]== 'B') {  
            sequenceMillis[NBsequence] = temp.toInt();
            byte add =  receivedChars[n+1] -48;
            int change = PortAddress[add];
            String port = String(receivedChars[n]);
            sequencePortB[NBsequence]=sequencePortB[NBsequence-1] ^ change ; 
            sequencePortD[NBsequence]=sequencePortD[NBsequence-1] ^ sequencePortD[NBsequence] ;
      } else if (receivedChars[n]== 'D') {
            sequenceMillis[NBsequence] = temp.toInt();
            byte add =  receivedChars[n+1] -48;
            int change = PortAddress[add];
            String port = String(receivedChars[n]);
            sequencePortD[NBsequence]=sequencePortD[NBsequence-1] ^ change ; 
            sequencePortB[NBsequence]=sequencePortB[NBsequence-1] ^ sequencePortB[NBsequence] ;
     } else { 
            temp = temp + String(receivedChars[n]);
            
            
            }
 }

Serial.println("millis");
for (int i=0 ; i <= NBsequence; i++){Serial.println(sequenceMillis[i]);}
Serial.println("port B");
for (int i=0 ; i <= NBsequence; i++){Serial.println(sequencePortB[i]);}
Serial.println("port D");
for (int i=0 ; i <= NBsequence; i++){Serial.println(sequencePortD[i]);}
Serial.println("READY and START");
runSequence();       
}
