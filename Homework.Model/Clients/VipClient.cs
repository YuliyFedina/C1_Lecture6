using System;
using System.Collections.Generic;
using System.Text;

namespace Homework.Model.Clients
{
    class VipClient : BankClient
    {
        public override int MaxAccounts => 10;

        public VipClient(long id, string name) : base(id, name)
        {
        }
    }
}
