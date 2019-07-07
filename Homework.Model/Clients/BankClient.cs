using System;
using System.Collections.Generic;
using System.Linq;
using Homework.Model.Accounts;

namespace Homework.Model.Clients
{
    public abstract class BankClient
    {
        public long Id { get; } //Id Клиента
        public string Name { get; set; } //Имя Клиента
        public abstract int MaxAccounts { get; } //максимальное количество аккаунтов, которое может быть у клиента

        private List<BankAccount> _clientAccounts = new List<BankAccount>();

        public decimal WholeSum //сумма по всем счетам
        {
            get
            {
                decimal wholeSum = 0;
                for (int i = 0; i < _clientAccounts.Count; i++)
                {
                    wholeSum += _clientAccounts[i].Sum;
                }

                return wholeSum;
            }
        }

        public BankClient(long id, string name)
        {
            Id = id;
            Name = name;
        }

        public void AddAccount(BankAccount bankAccount) //добавление счета клиенту
        {
            if (_clientAccounts.Count >= MaxAccounts)
            {
                throw new Exception($"Нельзя добавить клиенту больше {MaxAccounts} счетов");
            }
            _clientAccounts.Add(bankAccount);
        }

        public void CreateCheckingAccountForClient(long accountId, decimal accountSum, decimal accountServiceCharge) //создание расчетного счета для клиента
        {
            var account = new CheckingAccount(accountId, accountSum, accountServiceCharge);
            AddAccount(account);
        }

        public void CreateSavingAccountForClient(long accountId, decimal sum) //создание сберегательного счета для клиента
        {
            var account = new SavingAccount(accountId, sum);
            AddAccount(account);
        }

        public void CloseAccount(long accountId) //закрытие счета клинта
        {
            var account = _clientAccounts.FirstOrDefault(x => x.Id == accountId);
            if (account == null)
            {
                throw new Exception("Счет для клиента не найден");
            }
            account.Close();
        }
    }
}
