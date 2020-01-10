

/*

* To do
*  Change the below to direct port address
*
*/




/*
****************************************
* Function openSolenoid
* opens a solenoid valve
* done this way so that a constant value is used.
*
*/
void openSolenoid(byte s)
{
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
