

void checkData()
{
 bool checked = true; 
 
  for (int i = 1 ; i <= NBDrops ; i++) {
    if (sequenceMillis[i] == 0){checked= false;} }
   if (checked == true) {
      haveNewData = false;
      digitalWrite(LED_WAITING_PIN, LOW);
      BTserial.println("READY");
  }
}

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
   BTserial.println(data);
   Serial.println(data);
 }
}
void storeSequence()
{
 int len = strlen(receivedChars);
                  

 String temp;
 byte pos = receivedChars[1] -48;
 Serial.println(pos); 
 Serial.println(pos);
 byte posLetter = 0;
 //Format : [X1:1000B4]
 for (int i = 3; i <= len -2 ; i++) {
       Serial.println("insert data");               
      if (isDigit(receivedChars[i]) == false){  posLetter = i; Serial.println(i);}
      else { temp = temp + String(receivedChars[i]); Serial.println(temp); }                     

 }

 String port = String(receivedChars[posLetter]);
 byte add = receivedChars[posLetter+1] -48;
 Serial.println(temp);
 int change = PortAddress[add];
 sequenceMillis[pos] = temp.toInt();
  if (port == "B"){sequencePortB[pos]=sequencePortB[pos-1] ^ change ;} 
  else { sequencePortD[pos]=sequencePortD[pos-1] ^ change ;} 
       
receivedChars[0] = '\0';
       
}
