using DataAcess.Crud;
using GreenMonkey.DataAccess.Dao;
using GreenMonkey.DataAccess.Mapper;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.DataAccess.Crud
{
    public class CoinCrudFactory : CrudFactory
    {
        CoinMapper mapper;

        public CoinCrudFactory() : base()
        {
            mapper = new CoinMapper();
            dao = SqlDao.GetInstance();
        }
        public override void Create(BaseEntity entity)
        {
            var coin = (Coin)entity;
            var sqlOperation = mapper.GetCreateStatement(coin);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }
        public T RetrieveByFintech<T>(BaseEntity entity)
        {
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveByFintechStatement(entity));
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                dic = lstResult[0];
                var objs = mapper.BuildObject(dic);
                return (T)Convert.ChangeType(objs, typeof(T));
            }

            return default(T);
        }

        public override List<T> RetrieveAll<T>()
        {
            var lstCoins = new List<T>();

            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstCoins.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }

            return lstCoins;
        }

        public override void Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
