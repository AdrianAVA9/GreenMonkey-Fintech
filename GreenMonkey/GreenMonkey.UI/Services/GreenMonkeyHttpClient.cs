using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;

namespace GreenMonkey.UI.Services
{
    public class GreenMonkeyHttpClient
    {
        private readonly static string GreenMonkeyWepApi = "https://localhost:44307/api/";
        public static HttpClient GetClient()
        {
            var client = new HttpClient()
            {
                BaseAddress = new Uri(GreenMonkeyWepApi)            
            };

            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

            /* Json web token */
            //client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);

            return client;
        }
    }
}