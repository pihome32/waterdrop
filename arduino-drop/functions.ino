


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

  //Format : [D1000B4,30000D7]
 for (byte n = 1; n < dataRecvCount; n++) {
      char loopChar=  char(dataRecvd[n]);
      if (loopChar == ',') {
        NBsequence++;
        temp = "";
      }
      else if (isDigit(loopChar)== false) {  
        Serial.println("2222222222");
        sequenceMillis[NBsequence] = temp.toInt();
        byte add =  char(dataRecvd[n+1]) -48;
        int change = PortAddress[add];
        String port = String(loopChar);
        if (port == "B"){sequencePortB[NBsequence]=sequencePortB[NBsequence-1] ^ change ;} 
        else { sequencePortD[NBsequence]=sequencePortD[NBsequence-1] ^ change ;} 
     } 
 }

Serial.println("millis");
for (int i=0 ; i <= NBsequence; i++){Serial.println(sequenceMillis[i]);}
       
}
