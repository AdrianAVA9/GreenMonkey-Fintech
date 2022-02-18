using GreenMonkey.DataAccess;
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
        public void AddFintech(List<FintechStatus> fintechStatuses)
        {
            fintechStatuses.ForEach(fintechStatus => {
                MemoryPersistence.StoreData(fintechStatus.Suscriptor.Code, fintechStatus);
            });
        }
    }
}
