using AutoMapper;
using DataAcess.Crud;
using GreenMonkey.Dtos;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace GreenMonkey.Api.Controllers
{
    [RoutePrefix("api/suscriptors")]
    public class SuscriptorController : ApiController
    {
        private SuscriptorCrudFactory _suscriptorCrud { get; set; }
        public IMapper _mapper { get; set; }
        public SuscriptorController(IMapper mapper)
        {
            _suscriptorCrud = new SuscriptorCrudFactory();
            _mapper = mapper;
        }
        
        [Route("")]
        [HttpGet]
        public IHttpActionResult RetreaveAll()
        {
            try
            {
                var suscriptors = _suscriptorCrud.RetrieveAll<Suscriptor>();
                var apiResponse = new ApiResponse() { 
                    Data = suscriptors.Select(suscriptor => _mapper.Map<SuscriptorDto>(suscriptor))
                };

                return Ok(apiResponse);
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }

        [Route("{code}")]
        [HttpGet]
        public IHttpActionResult RetreaveSuscriptor(string code)
        {
            try
            {
                var suscriptor = _suscriptorCrud.Retrieve<Suscriptor>(new Suscriptor() { Code = code });

                //if(suscriptor == null)
                //{
                //    return NotFound();
                //}

                var apiResponse = new ApiResponse()
                {
                    Data = _mapper.Map<SuscriptorDto>(suscriptor),
                    Message = suscriptor == null 
                        ? String.Format("The suscriptor code: {0} does not exists", code) 
                        : ""
                };

                return Ok(apiResponse);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
