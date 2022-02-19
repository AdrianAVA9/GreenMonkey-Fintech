using AutoMapper;
using DataAcess.Crud;
using GreenMonkey.Dtos;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
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
    }
}
