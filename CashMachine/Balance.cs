using System;
using System.Collections.Generic;
using System.Text;

namespace CashMachine
{
    class Balance
    {
        public int ActualBalance { get; private set; }

        public Balance(int ActualBalance)
        {
            this.ActualBalance = ActualBalance;
        }
        public int SetBalance(int NewBalance)
        {
            ActualBalance = NewBalance;
            return NewBalance;
        }
    }
}