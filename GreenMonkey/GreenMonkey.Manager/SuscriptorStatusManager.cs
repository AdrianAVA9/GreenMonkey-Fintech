using GreenMonkey.DataAccess.Crud;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Manager
{
    public class SuscriptorStatusManager
    {
        public SuscriptorStatusCrudFactory SuscriptorStatusFactory { get; set; }
        public SuscriptorStatusManager()
        {
            SuscriptorStatusFactory = new SuscriptorStatusCrudFactory();
        }

        public void CreateSuscriptorStatus(SuscriptorStatus suscriptorStatus)
        {
            SuscriptorStatusFactory.Create(suscriptorStatus);
        }

        public void UpdateSuscriptorStatus(SuscriptorStatus suscriptorStatus)
        {
            SuscriptorStatusFactory.Update(suscriptorStatus);
        }

        public List<SuscriptorStatus> RetrieveAllSuscriptorsStatus()
        {
            return SuscriptorStatusFactory.RetrieveAll<SuscriptorStatus>();
        }

        public SuscriptorStatus RetrieveSuscriptorStatus(SuscriptorStatus suscriptorStatus)
        {
            return SuscriptorStatusFactory.Retrieve<SuscriptorStatus>(suscriptorStatus);
        }

        public void DeleteSuscriptorStatus(SuscriptorStatus suscriptorStatus)
        {
            SuscriptorStatusFactory.Delete(suscriptorStatus);
        }
    }
}
