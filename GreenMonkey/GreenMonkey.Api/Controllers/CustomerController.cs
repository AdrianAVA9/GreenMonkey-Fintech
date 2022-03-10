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

        [Route("")]
        [HttpPut]
        public IHttpActionResult UpdateCustomer([FromBody] CustomerDto customerDto)
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

                if (existingCustomer == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("Id", string.Format("The customer id: {0} does not exists", customer.Id))
                    });
                }

                _customerManager.UpdateCustomer(customer);

                return Ok(customerDto);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("{id}")]
        [HttpDelete]
        public IHttpActionResult DeleteCustomer(string id)
        {
            try
            {
                var existingCustomer = _customerManager.RetrieveCustomer(new Customer() { Id = id });

                if (existingCustomer == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("Customer", string.Format("The customer code: {0} does not exists", id))
                    });
                }

                _customerManager.DeleteCustomer(existingCustomer);

                return StatusCode(HttpStatusCode.NoContent);
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult RetreaveCustomer(string id)
        {
            try
            {
                var customer = _customerManager.RetrieveCustomer(new Customer() { Id = id });

                if (customer == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("customer", string.Format("The customer id: {0} does not exists", id) )
                    });
                }

                return Ok(_mapper.Map<CustomerDto>(customer));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult RetreaveAllCustomers()
        {
            try
            {
                var customers = _customerManager.RetrieveAllCustomers();

                return Ok(customers.Select(customer => _mapper.Map<CustomerDto>(customer)));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
