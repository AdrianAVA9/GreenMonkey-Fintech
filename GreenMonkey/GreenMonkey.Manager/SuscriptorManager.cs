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
        public SuscriptorCrudFactory SuscriptorFactory { get; private set; }

        public SuscriptorManager()
        {
            SuscriptorFactory = new SuscriptorCrudFactory();
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
            return SuscriptorFactory.RetrieveAll<Suscriptor>();
        }

        public Suscriptor RetrieveSuscriptor(Suscriptor suscriptor)
        {
            return SuscriptorFactory.Retrieve<Suscriptor>(suscriptor);
        }

        public void DeleteSuscriptor(Suscriptor suscriptor)
        {
            SuscriptorFactory.Delete(suscriptor);
        }
    }
}
