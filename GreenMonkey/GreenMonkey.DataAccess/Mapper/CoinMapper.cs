using GreenMonkey.DataAccess.Dao;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.DataAccess.Mapper
{
    public class CoinMapper : EntityMapper, ISqlStaments, IObjectMapper
    {
        private const string DB_COL_CODE = "CODE";
        private const string DB_COL_NAME = "NAME";
        private const string DB_COL_FINTECH_CODE = "FINTECH_CODE";

        public SqlOperation GetCreateStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "CRE_COIN_PR" };

            var coin = (Coin)entity;
            operation.AddVarcharParam(DB_COL_NAME, coin.Name);
            operation.AddVarcharParam(DB_COL_FINTECH_CODE, coin.FintechCode);

            return operation;
        }

        public SqlOperation GetDeleteStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public SqlOperation GetRetriveAllStatement()
        {
            var operation = new SqlOperation { ProcedureName = "RET_ALL_COIN_PR" };
            return operation;
        }

        public SqlOperation GetRetriveStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_COIN_PR" };

            var c = (Coin)entity;
            operation.AddVarcharParam(DB_COL_CODE, c.Code);

            return operation;
        }

        public SqlOperation GetRetriveByFintechStatement(BaseEntity entity)
        {
            var operation = new SqlOperation { ProcedureName = "RET_COIN_BY_FINTECH_PR" };

            var c = (Coin)entity;
            operation.AddVarcharParam(DB_COL_FINTECH_CODE, c.FintechCode);

            return operation;
        }

        public SqlOperation GetUpdateStatement(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public BaseEntity BuildObject(Dictionary<string, object> row)
        {
            var coin = new Coin
            {
                Code = GetStringValue(row, DB_COL_CODE),
                Name = GetStringValue(row, DB_COL_NAME),
                FintechCode = GetStringValue(row, DB_COL_FINTECH_CODE)
            };

            return coin;
        }

        public List<BaseEntity> BuildObjects(List<Dictionary<string, object>> lstRows)
        {
            var lstResults = new List<BaseEntity>();

            foreach (var row in lstRows)
            {
                var coin = BuildObject(row);
                lstResults.Add(coin);
            }

            return lstResults;
        }
    }
}
