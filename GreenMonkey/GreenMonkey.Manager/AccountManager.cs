using GreenMonkey.DataAccess.Crud;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Manager
{
    public class AccountManager
    {
        public AccountCrudFactory AccountFactory { get; private set; }
        public AccountManager()
        {
            AccountFactory = new AccountCrudFactory();
        }

        public void CreateAccount(Account account)
        {
            AccountFactory.Create(account);
        }

        public Account RetrieveAccount(Account account)
        {
            return AccountFactory.Retrieve<Account>(account);
        }
    }
}
