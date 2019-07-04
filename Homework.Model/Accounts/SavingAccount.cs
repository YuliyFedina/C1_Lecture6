namespace Homework.Accounts
{
    class SavingAccount : BankAccount
    {
        public SavingAccount(long id, decimal sum) : base(id, sum)
        {
        }

        public SavingAccount(long id) : base(id)
        {
        }
    }
}