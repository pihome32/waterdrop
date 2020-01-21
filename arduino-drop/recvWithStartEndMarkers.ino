
     
// function recvWithStartEndMarkers by Robin2 of the Arduino forums
// See  http://forum.arduino.cc/index.php?topic=288234.0
/*
****************************************
* Function recvWithStartEndMarkers
* reads serial data and returns the content between a start marker and an end marker.
* 
*  Lazy solution. I created 2 different versions. One to handle hardware serial and one to handle software serial
*/


void getSerialBT() {
    static byte ndx = 0;
    char rc;

    while (BTserial.available() > 0 && newData == false) {
        rc = BTserial.read();

        if (inBTProgress == true) {
            if (rc != endMarker) {
                receivedChars[ndx] = rc;
                ndx++;
                if (ndx >= numChars) {
                    ndx = numChars - 1;
                }
            }
            else {
                receivedChars[ndx] = '\0'; // terminate the string
                inBTProgress = false;
                ndx = 0;
                newData = true;
            }
        }

        else if (rc == startMarker) {
            inBTProgress = true;
        }
    }
}
