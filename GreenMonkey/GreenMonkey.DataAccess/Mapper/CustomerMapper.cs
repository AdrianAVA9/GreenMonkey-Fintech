using GreenMonkey.DataAccess.Dao;
using GreenMonkey.Models;
using System.Collections.Generic;

namespace GreenMonkey.DataAccess.Mapper
{
    public class CustomerMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_NAME = "NAME";
        private const string DB_COL_LASTNAME = "LASTNAME";
        private const string DB_COL_NICKNAME = "NICKNAME";
        private const string DB_COL_STATUS = "STATUS";
        private const string DB_COL_BIRTHDATE = "BIRTHDATE";
        private const string DB_COL_REGISTER_AT = "REGISTERED_AT";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddVarcharParam(DB_COL_LASTNAME, c.LastName);
            operation.AddVarcharParam(DB_COL_NICKNAME, c.Nickname);
            operation.AddVarcharParam(DB_COL_STATUS, c.Status);
            operation.AddDateTimeParam(DB_COL_BIRTHDATE, c.Birthdate);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);

            return operation;
        }

        SqlOperation ISqlStaments.GetRetriveAllStatement()
        {
            throw new System.NotImplementedException();
        }

        SqlOperation ISqlStaments.GetUpdateStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        SqlOperation ISqlStaments.GetDeleteStatement(BaseEntity entity)
        {
            throw new System.NotImplementedException();
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var customer = BuildObject(row);
                lstResults.Add(customer);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var customer = new Customer
            {
                Id = GetStringValue(row, DB_COL_ID),
                Name = GetStringValue(row, DB_COL_NAME),
                LastName = GetStringValue(row, DB_COL_LASTNAME),
                Nickname = GetStringValue(row, DB_COL_NICKNAME),
                Status = GetStringValue(row, DB_COL_STATUS),
                Birthdate = GetDateValue(row, DB_COL_BIRTHDATE),
                RegisteredAt = GetDateValue(row, DB_COL_REGISTER_AT),
            };

            return customer;
        }
    }
}
