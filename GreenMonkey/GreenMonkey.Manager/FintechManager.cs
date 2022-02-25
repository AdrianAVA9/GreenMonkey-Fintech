using DataAcess.Crud;
using GreenMonkey.DataAccess;
using GreenMonkey.DataAccess.Crud;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.Manager
{
    public class FintechManager
    {
        private SuscriptorStatusCrudFactory SuscriptorStatusFactory { get; set; }
        private SuscriptorCrudFactory SuscriptorFactory { get; set; }
        public FintechManager()
        {
            SuscriptorStatusFactory = new SuscriptorStatusCrudFactory();
            SuscriptorFactory = new SuscriptorCrudFactory();
        }
        public void AddFintech(List<FintechStatus> fintechStatuses)
        {
            foreach(var fintechStatus in fintechStatuses)
            {
               var existingSuscriptor = SuscriptorFactory.Retrieve<Suscriptor>(fintechStatus.Suscriptor);

                if(existingSuscriptor != null)
                {
                    SuscriptorFactory.Update(fintechStatus.Suscriptor);
                }
                else
                {
                    SuscriptorFactory.Create(fintechStatus.Suscriptor);
                }

                SuscriptorStatusFactory.Create(new SuscriptorStatus() { 
                    Status = fintechStatus.Status,
                    Code = fintechStatus.Suscriptor.Code,
                    UpdatedDate = fintechStatus.UpdatedDate
                });
            }
        }

        public List<FintechStatus> RetrieveAllAddFintech()
        {
            var suscriptors = SuscriptorFactory.RetrieveAll<Suscriptor>();
            var fintechStatusList = new List<FintechStatus>();

            foreach (var suscriptor in suscriptors)
            {
                var suscriptorStatusList = SuscriptorStatusFactory.RetrieveAll<SuscriptorStatus>(new SuscriptorStatus() { Code = suscriptor.Code });
                var fintechStatus = new FintechStatus()
                {
                    Suscriptor = suscriptor
                };

                if (suscriptorStatusList.Any())
                {
                    var lastStatus = suscriptorStatusList.Last();
                    fintechStatus.Status = lastStatus.Status;
                    fintechStatus.UpdatedDate = lastStatus.UpdatedDate;
                }

                fintechStatusList.Add(fintechStatus);
            }

            return fintechStatusList;
        }
    }
}
