using GreenMonkey.Api.ThirdPartyApi;
using GreenMonkey.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GreenMonkey.Api.Controllers
{
    [RoutePrefix("api/Init")]
    public class InitController : ApiController
    {
        private CenfoBankSource CenfoBank { get; set; }
        public InitController()
        {
            CenfoBank = new CenfoBankSource();
        }

        [HttpPost]
        [Route("")]
        public async Task<string> Init()
        {
            var result = await CenfoBank.Init();

            if (result)
                return "Ok";

            return "We could not start the connection";
        }

        [HttpGet]
        [Route("RetrieveAll")]
        public async Task<ApiResponse> RetrieveAllSuscriptor()
        {
            return await CenfoBank.RetrieveAllSuscriptor();
        }

        [HttpGet]
        [Route("HealthCheck")]
        public async Task<string> HealthCheck()
        {
            var result = await CenfoBank.HealthCheck();

            if (result)
                return "Ok";

            return "The service is down";
        }
    }
}
