using GreenMonkey.DataAccess.Dao;
using GreenMonkey.Models;
using System.Collections.Generic;

namespace GreenMonkey.DataAccess.Mapper
{
    public class SuscriptorMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_CODE = "CODE";
        private const string DB_COL_NAME = "NAME";


        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "CRE_SUSCRIPTOR_PR"};

            var c = (Suscriptor) entity;            
            operation.AddVarcharParam(DB_COL_CODE, c.Code);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);

            return operation;
        }


        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation {ProcedureName = "RET_SUSCRIPTOR_PR"};

            var c = (Suscriptor)entity;
            operation.AddVarcharParam(DB_COL_CODE, c.Code);
         
            return operation;
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_SUSCRIPTOR_PR" };            
            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "UPD_SUSCRIPTOR_PR" };

            var c = (Suscriptor)entity;
            operation.AddVarcharParam(DB_COL_CODE, c.Code);
            operation.AddVarcharParam(DB_COL_NAME, c.Name);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "DEL_SUSCRIPTOR_PR" };

            var c = (Suscriptor)entity;
            operation.AddVarcharParam(DB_COL_CODE, c.Code);
            return operation;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var SUSCRIPTOR = BuildObject(row);  
                lstResults.Add(SUSCRIPTOR);
            }

            return lstResults;            
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var suscriptor = new Suscriptor
            {
                Code = GetStringValue(row, DB_COL_CODE),
                Name = GetStringValue(row, DB_COL_NAME),
           };

            return suscriptor;
        }       

    }
}
