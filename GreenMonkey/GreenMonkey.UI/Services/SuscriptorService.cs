using GreenMonkey.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GreenMonkey.UI.Services
{
    public class SuscriptorService
    {
        private const string Collection = "suscriptors";
        public ICollection<Suscriptor> RetreaveSuscriptors()
        {
            var client = GreenMonkeyHttpClient.GetClient();
            var result = client.GetAsync(Collection).Result;

            if (!result.IsSuccessStatusCode)
                return new List<Suscriptor>();

            var content = result.Content.ReadAsStringAsync().Result;
            var suscriptors = Newtonsoft.Json.JsonConvert.DeserializeObject<ICollection<Suscriptor>>(content);
            return suscriptors;
        }

        public Suscriptor RetreaveSuscriptor(string code)
        {
            var client = GreenMonkeyHttpClient.GetClient();
            var result = client.GetAsync(string.Format("{0}/{1}", Collection, code)).Result;

            if (!result.IsSuccessStatusCode)
                return null;

            var content = result.Content.ReadAsStringAsync().Result;
            return Newtonsoft.Json.JsonConvert.DeserializeObject<Suscriptor>(content);
        }
    }
}