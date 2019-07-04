
using System;

namespace Homework.Accounts
{
    public abstract class BankAccount
    {
        public long Id { get; set; } //Номер счета
        public string Owner { get; set; } //Владелец счета
        public decimal Sum { get; protected set; } //Сумма на счету
        public bool IsActive { get; private set; } //Если false, то счет закрыт//


        public BankAccount(long id, decimal sum)
        {
            Id = id;
            Sum = sum;
            IsActive = true;
        }

        public BankAccount(long id) : this(id, 0)
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
                throw new ArgumentOutOfRangeException("Сумма операции должна быть больше нуля");
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
