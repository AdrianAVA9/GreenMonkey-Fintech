using GreenMonkey.DataAccess.Crud;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Manager
{
    public class SuscriptorManager : BaseManager
    {
        private SuscriptorCrudFactory SuscriptorFactory { get; set; }
        private SuscriptorStatusCrudFactory SuscriptorStatusFactory { get; set; }

        public SuscriptorManager()
        {
            SuscriptorFactory = new SuscriptorCrudFactory();
            SuscriptorStatusFactory = new SuscriptorStatusCrudFactory();
        }

        public void CreateSuscriptor(Suscriptor suscriptor)
        {
            SuscriptorFactory.Create(suscriptor);
        }

        public void UpdateSuscriptor(Suscriptor suscriptor)
        {
            SuscriptorFactory.Update(suscriptor);
        }

        public List<Suscriptor> RetrieveAllSuscriptors()
        {
            var suscriptors = SuscriptorFactory.RetrieveAll<Suscriptor>();

            foreach (var suscriptor in suscriptors)
            {
                suscriptor.StatusList = SuscriptorStatusFactory.RetrieveAll<SuscriptorStatus>(new SuscriptorStatus() { Code = suscriptor.Code });
            }

            return suscriptors;
        }

        public Suscriptor RetrieveSuscriptor(Suscriptor suscriptor)
        {
            var existingSuscriptor = SuscriptorFactory.Retrieve<Suscriptor>(suscriptor);

            if(existingSuscriptor != null)
            {
                existingSuscriptor.StatusList = SuscriptorStatusFactory.RetrieveAll<SuscriptorStatus>(new SuscriptorStatus() { Code = suscriptor.Code });
            }

            return existingSuscriptor;
        }

        public void DeleteSuscriptor(Suscriptor suscriptor)
        {
            SuscriptorFactory.Delete(suscriptor);
        }
    }
}
