using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine
{
    class Logic
    {
        public static void CheckInputs(bool CheckUserBalance, bool CheckUserPin)
        {
            if (CheckUserBalance && CheckUserPin)
            {
                Console.WriteLine($"Your requested amount is being issued");
            }
            if(CheckUserBalance && !CheckUserPin)
            {
                Console.WriteLine("You don't have sufficient money in your account for that withdrawl");
            }
            if (!CheckUserBalance && CheckUserPin)
            {
                Console.WriteLine("Your Pin is incorrect");
            }
            if (!CheckUserBalance && !CheckUserPin)
            {
                Console.WriteLine("It's all wrong");
            }
        }
    }
}
