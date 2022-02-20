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
        [HttpPost]
        public IHttpActionResult CreateSuscriptor([FromBody] SuscriptorDto suscriptorDto)
        {
            try
            {
                if (suscriptorDto == null || !_validator.Validate(suscriptorDto).IsValid)
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

                if (existingSuscriptor != null)
                {
                    return new ErrorResult(Request, HttpStatusCode.Conflict, new List<ValidationFailure>() {
                        new ValidationFailure("Code", string.Format("The suscriptor code: {0} already exists", suscriptor.Code))
                    });
                }

                _suscriptorCrud.Create(suscriptor);
                var newSuscriptor = _suscriptorCrud.Retrieve<Suscriptor>(suscriptor);

                return Created(string.Format("{0}/suscriptors/{1}", Request.RequestUri, newSuscriptor.Code),
                    _mapper.Map<SuscriptorDto>(newSuscriptor));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
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

                return Ok(suscriptors.Select(suscriptor => _mapper.Map<SuscriptorDto>(suscriptor)));
            }
            catch (Exception)
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
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("Suscriptor", string.Format("The suscriptor code: {0} does not exists", code) )
                    });
                }

                return Ok(_mapper.Map<SuscriptorDto>(suscriptor));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("{code}")]
        [HttpDelete]
        public IHttpActionResult DeleteSuscriptor(string code)
        {
            try
            {
                var existingSuscriptor = _suscriptorCrud.Retrieve<Suscriptor>(new Suscriptor() { Code = code });

                if (existingSuscriptor == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("Suscriptor", string.Format("The suscriptor code: {0} does not exists", code))
                    });
                }

                _suscriptorCrud.Delete(existingSuscriptor);

                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
