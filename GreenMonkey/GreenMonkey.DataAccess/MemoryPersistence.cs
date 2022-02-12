using GreenMonkey.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreenMonkey.DataAccess
{
    public static class MemoryPersistence
    {
        public static Dictionary<string, object> Persistency = new Dictionary<string, object>();
        public static void StoreData(string code, object data)
        {
            Persistency[code] = data;
        }
        public static Dictionary<string, object> GetData()
        {
            return Persistency;
        }
    }
}
