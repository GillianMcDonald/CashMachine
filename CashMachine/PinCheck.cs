using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine
{
    class PinCheck
    {
        public static bool CheckUserPin(int ActualPin, int UserInputPin){
            if (ActualPin == UserInputPin)
            {
               // Console.WriteLine("Check Pin: pin is true");
                return true;
            }
            else
            {
               //Console.WriteLine("Check Pin: pin is false");
                return false;
            }
        }

    }
}
