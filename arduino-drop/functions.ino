




void sequenceReset()
{
    for (int i = 0; i < 10; i++) {
        sequencePortB[i]=B000000;
        sequencePortB[i]=B00000000;
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
