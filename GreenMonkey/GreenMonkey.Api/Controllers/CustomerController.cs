using AutoMapper;
using FluentValidation.Results;
using GreenMonkey.Api.Models;
using GreenMonkey.Api.Validators;
using GreenMonkey.Dtos;
using GreenMonkey.Manager;
using GreenMonkey.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GreenMonkey.Api.Controllers
{
    [RoutePrefix("api/customers")]
    public class CustomerController : ApiController
    {
        private CustomerManager _customerManager { get; set; }
        public IMapper _mapper { get; set; }
        public CustomerValidator _validator { get; set; }
        public CustomerController(IMapper mapper, CustomerValidator validator)
        {
            _customerManager = new CustomerManager();
            _validator = validator;
            _mapper = mapper;
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult CreateCustomer([FromBody] CustomerDto customerDto)
        {
            try
            {
                if (customerDto == null || !_validator.Validate(customerDto).IsValid)
                {
                    var validations = new List<ValidationFailure>();

                    if (customerDto == null)
                    {
                        validations.Add(new ValidationFailure("Customer", "The customer can not be null"));
                    }
                    else
                    {
                        validations.AddRange(_validator.Validate(customerDto).Errors);
                    }

                    return new ErrorResult(Request, HttpStatusCode.BadRequest, validations);
                }

                var customer = _mapper.Map<Customer>(customerDto);
                var existingCustomer = _customerManager.RetrieveCustomer(customer);

                if (existingCustomer != null)
                {
                    return new ErrorResult(Request, HttpStatusCode.Conflict, new List<ValidationFailure>() {
                        new ValidationFailure("Id", string.Format("The customer id: {0} already exists", customerDto.Id))
                    });
                }

                _customerManager.CreateCustomer(customer);
                var newCustomer = _customerManager.RetrieveCustomer(customer);

                return Created(string.Format("{0}/customers/{1}", Request.RequestUri, newCustomer.Id),
                    _mapper.Map<CustomerDto>(newCustomer));
            }
            catch (Exception ex)
            {
                return InternalServerError();
            }
        }
    }
}
