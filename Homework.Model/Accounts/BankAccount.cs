using System;

namespace Homework.Model.Accounts
{
    public abstract class BankAccount
    {
        public long Id { get; }
        public string Owner { get; set; }
        public decimal Sum { get; protected set; }
        private bool IsActive { get; set; }


        public BankAccount(long id, decimal sum)
        {
            Id = id;
            Sum = sum;
            IsActive = true;
        }

        public BankAccount(long id) : this(id, 0)
        {
        }

        public BankAccount()
        {
        }


        public void Close()
        {
            if (Sum != 0)
            {
                throw new Exception("Счет не может быть закрыт при положителыном балансе");
            }

            IsActive = false;
        }

        public bool GetStatus()
        {
            return IsActive;
        }

        public static void ValidationAmount(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException($"Сумма операции ={amount}, а должна быть больше нуля");
            }
        }
        public void EnsureAccountIsActive()
        {
            if (!IsActive)
            {
                throw new Exception("Операция невозможна для закрытого счета");
            }
        }

        public virtual void AddFunds(decimal amount)
        {
            ValidationAmount(amount);
            EnsureAccountIsActive();
            Sum += amount;
        }

        public virtual void WithdrawFunds(decimal amount)
        {
            ValidationAmount(amount);
            EnsureAccountIsActive();
            if (amount > Sum)
            {
                throw new Exception("Сумма списания больше остатка");
            }
            Sum -= amount;
        }
    }
}
