using System;
using System.Collections.Generic;
using System.Text;
using Homework.Accounts;

namespace Homework
{
    class Bank
    {
        public void Transaction(BankAccount from, BankAccount to, decimal sum)
        {
            from.WithdrawFunds(sum);
            to.AddFunds(sum);
        }
    }
}
