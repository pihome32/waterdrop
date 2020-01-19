
/*function to create the drop sequence with flash and camera
 * 
 */

unsigned long StartTime;

void runSequence()  
{
    Serial.end();
    BTserial.end();
    unsigned int realMillis[10] = {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0} ;
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
        realMillis[cmd]=millis()-StartTime;
      }
      if (cmd >= NBDrops) {
        done = true;
      }
    
  }
  PORTD = B00000000;
  PORTB = B000000;
  
  Serial.begin(9600);
  BTserial.begin(9600);
  BTserial.println("Sequence terminated");
  for (int i = 0; i < NBDrops; i++) {
    BTserial.println(String(realMillis[i])); }
 

}
