using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine
{
    class Pin
    {
        public int ActualPin { get; set; }

        public Pin(int ActualPin)
        {
           this.ActualPin = ActualPin;
        }
        public int SetPin(int NewPin)
        {
            //Console.WriteLine($"From SetPin function.  New pin request is {NewPin}");
            ActualPin = NewPin;
            return NewPin;
        }

        //public void changePinRequest(string UserAnswer)
        //{
        //    if (UserAnswer == "y" || UserAnswer == "Y")
        //    {
        //        Console.WriteLine("Please enter a new 4 digit pin");
        //        var readChangePin = Console.ReadLine();
        //        var NewPin = Convert.ToInt32(readChangePin);
        //        SetPin(NewPin);
        //        pin.SetPin(NewPin);
        //        ActualPin = pin.ActualPin;
        //        Console.WriteLine("Your pin has been changed");

        //    }
        //    if (UserAnswer == "n" || UserAnswer == "N")
        //    {

        //    }
        //}
    }
}




  
    