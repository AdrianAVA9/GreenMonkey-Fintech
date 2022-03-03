using GreenMonkey.DataAccess.Dao;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.DataAccess.Mapper
{
    public class AccountMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_NUMBER = "NUMBER";
        private const string DB_COL_NAME = "NAME";
        private const string DB_COL_STATUS = "STATUS";
        private const string DB_COL_CUSTOMER_ID = "CUSTOMER_ID";
        private const string DB_COL_COIN_CODE = "COIN_CODE";
        private const string DB_COL_REGISTERED_AT = "REGISTERED_AT";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_ACCOUNT_PR" };

            var account = (Account)entity;
            operation.AddVarcharParam(DB_COL_NAME, account.Name);
            operation.AddVarcharParam(DB_COL_STATUS, account.Name);
            operation.AddVarcharParam(DB_COL_CUSTOMER_ID, account.CustomerId);
            operation.AddIntParam(DB_COL_COIN_CODE, account.CoinCode);

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

        public SqlOperation GetRetriveAllByCustomerStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_BY_CUSTOMER_PR" };
            var a = (Account)entity;
            operation.AddVarcharParam(DB_COL_CUSTOMER_ID, a.CustomerId);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_ACCOUNT_PR" };

            var a = (Account)entity;
            operation.AddVarcharParam(DB_COL_NUMBER, a.Number);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var account = BuildObject(row);
                lstResults.Add(account);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var account = new Account
            {
                Number = GetStringValue(row, DB_COL_NUMBER),
                Name = GetStringValue(row, DB_COL_NAME),
                Status = GetStringValue(row, DB_COL_STATUS),
                CustomerId = GetStringValue(row, DB_COL_CUSTOMER_ID),
                CoinCode = GetIntValue(row, DB_COL_COIN_CODE),
                RegisteredAt = GetDateValue(row, DB_COL_REGISTERED_AT),
            };

            return account;
        }
    }
}
