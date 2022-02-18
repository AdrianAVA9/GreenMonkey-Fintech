using GreenMonkey.Api.Mappers;
using GreenMonkey.Api.ThirdPartyApi;
using GreenMonkey.Dtos;
using GreenMonkey.Manager;
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
        public string HealthCheck()
        {
            return "Ok";
        }

        [HttpGet]
        [Route("HealthCheck")]
        public IHttpActionResult HealthCheck([FromBody] List<FintechStatusDto> fintechsDto)
        {
            try
            {
                if (fintechsDto == null)
                    return BadRequest(String.Format("The {0} is invalid", nameof(fintechsDto)));

                var manager = new FintechManager();
                var fintechs = fintechsDto.Select(fintech => FintechStatusMapper.GetFintech(fintech))
                    .ToList();
                manager.AddFintech(fintechs);

                return Ok();
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
