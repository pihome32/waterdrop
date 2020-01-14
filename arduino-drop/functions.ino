/*
****************************************
* Function openSolenoid
* opens a solenoid valve
*/
void openSolenoid(byte s)
{  Serial.print("opensol");
    // done this way so I can use a constant for the sol pin
    if      (s==1) { PORTD |=(1<< PORTD7);   }
    else if (s==2) { PORTD |=(1<< PORTD6);     }
    else if (s==3) { PORTD |=(1<< PORTD5);    }
    else if (s==4) { PORTD |=(1<< PORTD4);   }    

}

/*
****************************************
* Function closeSolenoid
* closes a solenoid valve
* 
*/
void closeSolenoid(byte s)
{
     // done this way so I can use a constant for the sol pin
    if      (s==1) { PORTD &=~ (1<<PORTD7);   }
    else if (s==2) { PORTD &=~ (1<<PORTD6);      }
    else if (s==3) { PORTD &=~ (1<<PORTD5);      }
    else if (s==4) { PORTD &=~ (1<<PORTD4);     }    
}

void FlashON(byte s)
{
    // done this way so I can use a constant for the sol pin
    if      (s==1) { PORTB |=(1<< PORTB2);   }
    else if (s==2) { PORTB |=(1<< PORTB1);     }
    else if (s==3) { PORTB |=(1<< PORTB0);    }
}

void FlashOFF(byte s)
{
     // done this way so I can use a constant for the sol pin
    if      (s==1) { PORTB &=~ (1<<PORTB2);   }
    else if (s==2) { PORTB &=~ (1<<PORTB1);      }
    else if (s==3) { PORTB &=~ (1<<PORTB0);      }
}

void Focus(byte s)
{
     // done this way so I can use a constant for the sol pin
    if      (s==0) { PORTB &=~ (1<<PORTB3);   }
    else if (s==1) { PORTB |= (1<<PORTB3);      }
}

void Shutter(byte s)
{
     // done this way so I can use a constant for the sol pin
    if      (s==0) { PORTB &=~ (1<<PORTB4);   }
    else if (s==1) { PORTB |= (1<<PORTB4);      }
}


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
