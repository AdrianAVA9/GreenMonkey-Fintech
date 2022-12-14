using GreenMonkey.DataAccess.Dao;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.DataAccess.Mapper
{
    public class SuscriptorStatusMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_ID = "ID";
        private const string DB_COL_CODE = "CODE";
        private const string DB_COL_STATUS = "STATUS";
        private const string DB_COL_UPDATED_DATE = "UPDATED_DATE";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_SUSCRIPTOR_STATUS_PR" };

            var c = (SuscriptorStatus)entity;
            operation.AddVarcharParam(DB_COL_CODE, c.Code);
            operation.AddVarcharParam(DB_COL_STATUS, c.Status);
            operation.AddDateTimeParam(DB_COL_UPDATED_DATE, c.UpdatedDate);

            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_SUSCRIPTOR_STATUS_BY_SUSCRIPTOR_PR" };

            var c = (SuscriptorStatus)entity;
            operation.AddVarcharParam(DB_COL_CODE, c.Code);
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var SUSCRIPTOR_STATUS = BuildObject(row);
                lstResults.Add(SUSCRIPTOR_STATUS);
            }

            return lstResults;
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var suscriptorStatus = new SuscriptorStatus
            {
                Id = GetIntValue(row, DB_COL_ID),
                Code = GetStringValue(row, DB_COL_CODE),
                Status = GetStringValue(row, DB_COL_STATUS),
                UpdatedDate = GetDateValue(row, DB_COL_UPDATED_DATE)
            };

            return suscriptorStatus;
        }
    }
}
