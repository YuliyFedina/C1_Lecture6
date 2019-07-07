namespace Homework.Model.Clients
{
    class SimpleClient : BankClient
    {
        public override int MaxAccounts => 3;

        public SimpleClient(long id, string name) : base(id, name)
        {
        }
    }
}
