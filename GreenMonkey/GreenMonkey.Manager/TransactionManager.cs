using GreenMonkey.DataAccess.Crud;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Manager
{
    public class TransactionManager
    {
        public TransactionCrudFactory TransactionFactory { get; set; }

        public TransactionManager()
        {
            TransactionFactory = new TransactionCrudFactory();
        }

        public void CreateTransaction(Transaction transaction)
        {
            TransactionFactory.Create(transaction);
        }

        public Transaction RetrieveTransaction(Transaction transaction)
        {
            return TransactionFactory.Retrieve<Transaction>(transaction);
        }

        public List<Transaction> RetrieveTransactionsByAccount(Transaction transaction)
        {
            return TransactionFactory.RetrieveAllByAccount<Transaction>(transaction);
        }
    }
}
