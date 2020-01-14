
unsigned long StartTime;

void runSequence()  
{

    boolean done=false;
    StartTime = millis(); 
    while (StartTime == millis())  // Make sure we are starting at the beginning of a millisecond
    {}
    StartTime = millis();
    byte cmd = 0;
    while (!done)
    {
      if (millis() - StartTime >= sequenceMillis[cmd]){
        ++cmd;
        PORTB = sequencePortB[cmd]; 
        PORTD = sequencePortD[cmd];
        printDebug(String(millis()));
        printDebug("portB");
        printDebug(String(sequencePortB[cmd]));
        printDebug("portD");
        printDebug(String(sequencePortD[cmd]));
      }
      if (cmd >= NBDrops) {
        done = true;
      }
    
  }

}
