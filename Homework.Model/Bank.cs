using Homework.Model.Accounts;

namespace Homework.Model
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
