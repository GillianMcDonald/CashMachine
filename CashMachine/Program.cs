using System;

namespace CashMachine
{
    class Program
    {
        static void Main(string[] args)
        {

            Pin pin = new Pin(5555);
            Balance bal = new Balance(50);

            int UserInputPin;
            int UserInputBalReq;
            int ActualPin = pin.ActualPin;
            int ActualBalance = bal.ActualBalance;

            Console.WriteLine($"The Actual pin is:  {ActualPin}");
            Console.WriteLine($"The Actual Balance is: {ActualBalance}");

            Console.WriteLine("Would you like to change your pin y/n");
            var UserAnswer = Console.ReadLine();
  
            if (UserAnswer == "y" || UserAnswer == "Y")
            {
                Console.WriteLine("Please enter a new 4 digit pin");
                var readChangePin = Console.ReadLine();
                var NewPin = Convert.ToInt32(readChangePin);
                pin.SetPin(NewPin);
                ActualPin = pin.ActualPin;
                Console.WriteLine("Your pin has been changed");
            }
            // calling a method / function from the same class - this is what I would be looking at next.
     

            Console.WriteLine("Please enter your pin: ");
            var readUserPin = Console.ReadLine();
            UserInputPin = Convert.ToInt32(readUserPin);
            //Console.WriteLine($"The pin you entered is: {UserInputPin}");
            bool PinResult = PinCheck.CheckUserPin(ActualPin, UserInputPin);

            Console.WriteLine("Please enter the amount you would like to withdraw: £ ");
            var readBalReq = Console.ReadLine();
            UserInputBalReq = Convert.ToInt32(readBalReq);
            //Console.WriteLine($"The amount you want to withdraw is: {UserInputBalReq}");
            bool BalResult = BalanceCheck.CheckUserBalance(ActualBalance, UserInputBalReq);
           
            Logic.CheckInputs(PinResult, BalResult);

        }
    }
}
