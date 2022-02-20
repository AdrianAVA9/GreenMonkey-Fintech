using AutoMapper;
using DataAcess.Crud;
using FluentValidation.Results;
using GreenMonkey.Api.Models;
using GreenMonkey.Api.Validators;
using GreenMonkey.Dtos;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
        public SuscriptorValidator _validator { get; set; }
        public SuscriptorController(IMapper mapper, SuscriptorValidator validator)
        {
            _suscriptorCrud = new SuscriptorCrudFactory();
            _validator = validator;
            _mapper = mapper;
        }

        [Route("")]
        [HttpPut]
        public IHttpActionResult UpdateSuscriptor([FromBody]SuscriptorDto suscriptorDto)
        {
            try
            {
                if(suscriptorDto == null || !_validator.Validate(suscriptorDto).IsValid)
                {
                    var validations = new List<ValidationFailure>();

                    if (suscriptorDto == null)
                    {
                        validations.Add(new ValidationFailure("Suscriptor", "The suscriptor can not be null"));
                    }
                    else
                    {
                        validations.AddRange(_validator.Validate(suscriptorDto).Errors);
                    }

                    return new ErrorResult(Request, HttpStatusCode.BadRequest, validations);
                }

                var suscriptor = _mapper.Map<Suscriptor>(suscriptorDto);
                var existingSuscriptor = _suscriptorCrud.Retrieve<Suscriptor>(suscriptor);
                
                if(existingSuscriptor == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("Code", string.Format("The suscriptor code: {0} does not exists", suscriptor.Code))
                    });
                }

                _suscriptorCrud.Update(suscriptor);

                return Ok(suscriptorDto);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult RetreaveAllSuscriptors()
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

                if (suscriptor == null)
                {
                    return NotFound();
                }

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
