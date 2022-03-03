using GreenMonkey.DataAccess.Dao;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.DataAccess.Mapper
{
    public class TransactionMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_AMOUNT = "AMOUNT";
        private const string DB_COL_TYPE = "TYPE";
        private const string DB_COL_ACCOUNT_NUMBER = "ACCOUNT_NUMBER";
        private const string DB_COL_REGISTERED_AT = "REGISTERED_AT";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_TRANSACTION_PR" };

            var transaction = (Transaction)entity;
            operation.AddDecimalParam(DB_COL_AMOUNT, transaction.Amount);
            operation.AddVarcharParam(DB_COL_TYPE, transaction.Type);
            operation.AddVarcharParam(DB_COL_ACCOUNT_NUMBER, transaction.AccountNumber);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            throw new NotImplementedException();
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            throw new NotImplementedException();
        }
    }
}
