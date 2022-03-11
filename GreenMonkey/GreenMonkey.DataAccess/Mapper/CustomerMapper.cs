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
        private const string DB_COL_PHONE_NUMBER = "PHONE_NUMBER";
        private const string DB_COL_EMAIL = "EMAIL";

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
            operation.AddVarcharParam(DB_COL_PHONE_NUMBER, c.PhoneNumber);
            operation.AddVarcharParam(DB_COL_EMAIL, c.Email);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);

            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_CUSTOMER_PR" };
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);
            operation.AddVarcharParam(DB_COL_LASTNAME, c.LastName);
            operation.AddVarcharParam(DB_COL_NICKNAME, c.Nickname);
            operation.AddVarcharParam(DB_COL_STATUS, c.Status);
            operation.AddDateTimeParam(DB_COL_BIRTHDATE, c.Birthdate);
            operation.AddVarcharParam(DB_COL_PHONE_NUMBER, c.PhoneNumber);
            operation.AddVarcharParam(DB_COL_EMAIL, c.Email);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_CUSTOMER_PR" };

            var c = (Customer)entity;
            operation.AddVarcharParam(DB_COL_ID, c.Id);
            return operation;
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
                PhoneNumber = GetStringValue(row, DB_COL_PHONE_NUMBER),
                Email = GetStringValue(row, DB_COL_EMAIL),
                RegisteredAt = GetDateValue(row, DB_COL_REGISTER_AT),
            };

            return customer;
        }
    }
}
