using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine
{
    class BalanceCheck
    {
        public static bool CheckUserBalance(int ActualBalance, int UserInputBalReq)
        {
            if (ActualBalance >= UserInputBalReq)
            {
                //Console.WriteLine("Check Balance: true. can withdraw");
                return true;
            }
            else
            {
               // Console.WriteLine("Check Balance: false. can't withdraw");
                return false;
            }
        }

    }
}
