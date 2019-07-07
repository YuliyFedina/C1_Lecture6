using System;

namespace Homework.Model.Accounts
{
    class CheckingAccount : BankAccount
    {
        public decimal ServiceCharge { get; private set; }

        public CheckingAccount(long id, decimal sum) : base(id, sum)
        {
        }

        public CheckingAccount(long id) : base(id)
        {
        }

        public CheckingAccount(long id, decimal sum, decimal serviceCharge)
            : base(id, sum)
        {
            ServiceCharge = serviceCharge;
        }

        public void WithdrawCheckingAccount()
        {
            ValidationAmount(ServiceCharge);
            EnsureAccountIsActive();
            if (ServiceCharge > Sum)
            {
                throw new Exception("Сумма списания больше остатка");
            }
            Sum -= ServiceCharge;
        }
    }
}
