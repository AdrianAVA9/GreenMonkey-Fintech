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
    public class TransactionCrudFactory : CrudFactory
    {
        TransactionMapper mapper;

        public TransactionCrudFactory() : base()
        {
            mapper = new TransactionMapper();
            dao = SqlDao.GetInstance();
        }

        public override void Create(BaseEntity entity)
        {
            var transaction = (Transaction)entity;
            var sqlOperation = mapper.GetCreateStatement(transaction);
            dao.ExecuteProcedure(sqlOperation);
        }

        public override void Delete(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override T Retrieve<T>(BaseEntity entity)
        {
            throw new NotImplementedException();
        }

        public override List<T> RetrieveAll<T>()
        {
            throw new NotImplementedException();
        }

        public override void Update(BaseEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
