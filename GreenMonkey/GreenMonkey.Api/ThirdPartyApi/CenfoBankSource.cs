using GreenMonkey.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;

namespace GreenMonkey.Api.ThirdPartyApi
{
    public class CenfoBankSource
    {
        private string URL { get; set; }

        public CenfoBankSource()
        {
            URL = "https://sunpe-cenfobank.azurewebsites.net/api/Suscription/";
        }

        public async Task<bool> Init()
        {
            var endpoint = "Subscribe";
            var httpClient = new HttpClient();
            var uri = new Uri(URL + endpoint);
            var suscriptor = new Suscriptor()
            {
                Name = "GreenMonkey",
                Description = "The bank of Green Monkey",
                Owner = "Adrián Vega",
                BaseUrl = "https://green-monkeybank.azurewebsites.net",
                Code = "1028"
            };

            var contentType = "application/json";
            var body = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(suscriptor));
            body.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
            var response = await httpClient.PostAsync(uri, body);

            return response.IsSuccessStatusCode;
        }

        public async Task<ApiResponse> RetrieveAllSuscriptor()
        {
            var endpoint = "RetrieveAll";
            var httClient = new HttpClient();
            var uri = new Uri(URL + endpoint);

            var response = await httClient.GetAsync(uri);

            if (!response.IsSuccessStatusCode)
                return new ApiResponse() { Message = "We could not load the suscriptors" };

            var data = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse>(data);
        }

        public async Task<bool> HealthCheck()
        {
            var endpoint = "Init";
            var httpClient = new HttpClient();
            var uri = new Uri(URL + endpoint);

            var response = await httpClient.PostAsync(uri, null);
            return response.IsSuccessStatusCode;
        }
    }
}