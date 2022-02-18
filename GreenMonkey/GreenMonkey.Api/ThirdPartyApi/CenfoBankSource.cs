using GreenMonkey.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace GreenMonkey.Api.ThirdPartyApi
{
    public class CenfoBankSource
    {
        private string BaseUrl { get; set; }

        public CenfoBankSource()
        {
            BaseUrl = "https://sunpe-cenfobank.azurewebsites.net/api/";
        }

        public async Task<bool> Init()
        {
            var endpoint = "Suscription/Subscribe";
            var httpClient = new HttpClient();
            var url = new Uri(BaseUrl + endpoint);
            var suscriptor = new SuscriptorDto()
            {
                Name = "GreenMonkey",
                Description = "The bank of Green Monkey",
                Owner = "Adrián Vega",
                BaseUrl = "https://green-monkeybank.azurewebsites.net",
                Code = "1028"
            };

            var contentType = "application/json";
            var body = new StringContent(Newtonsoft.Json.JsonConvert.SerializeObject(suscriptor),
                Encoding.UTF8);
            body.Headers.ContentType = new System.Net.Http.Headers.MediaTypeHeaderValue(contentType);
            var response = await httpClient.PostAsync(url, body);

            return response.IsSuccessStatusCode;
        }

        public async Task<ApiResponse> RetrieveAllSuscriptor()
        {
            var endpoint = "Suscription/RetrieveAll";
            var httClient = new HttpClient();
            var url = new Uri(BaseUrl + endpoint);

            var response = await httClient.GetAsync(url);

            if (!response.IsSuccessStatusCode)
                return new ApiResponse() { Message = "We could not load the suscriptors" };

            var data = await response.Content.ReadAsStringAsync();
            return Newtonsoft.Json.JsonConvert.DeserializeObject<ApiResponse>(data);
        }

        public async Task<bool> HealthCheck()
        {
            var endpoint = "Suscription/Init";
            var httpClient = new HttpClient();
            var url = new Uri(BaseUrl + endpoint);

            var response = await httpClient.PostAsync(url, null);
            return response.IsSuccessStatusCode;
        }
    }
}