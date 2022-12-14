using DataAcess.Crud;
using GreenMonkey.DataAccess.Dao;
using GreenMonkey.DataAccess.Mapper;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;

namespace GreenMonkey.DataAccess.Crud
{
    public class SuscriptorCrudFactory : CrudFactory
    {
        SuscriptorMapper mapper;

        public SuscriptorCrudFactory() : base()
        {
            mapper = new SuscriptorMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var customer=(Suscriptor) entity;
            var sqlOperation = mapper.GetCreateStatement(customer);
            dao.ExecuteProcedure(sqlOperation);
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
        public override List<T> RetrieveAll<T>()
        {
            var lstSuscriptors = new List<T>();
            
            var lstResult = dao.ExecuteQueryProcedure(mapper.GetRetriveAllStatement());
            var dic = new Dictionary<string, object>();
            if (lstResult.Count > 0)
            {
                var objs = mapper.BuildObjects(lstResult);
                foreach (var c in objs)
                {
                    lstSuscriptors.Add((T)Convert.ChangeType(c, typeof(T)));
                }
            }
           
            return lstSuscriptors;
        }

        public override void Update(BaseEntity entity)
        {
            var customer = (Suscriptor)entity;
            dao.ExecuteProcedure(mapper.GetUpdateStatement(customer));
        }

        public override void Delete(BaseEntity entity)
        {
            var customer = (Suscriptor)entity;
            dao.ExecuteProcedure(mapper.GetDeleteStatement(customer));
        }
    }
}
