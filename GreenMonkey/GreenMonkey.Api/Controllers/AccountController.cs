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
    [RoutePrefix("api/accounts")]
    public class AccountController : ApiController
    {
        private CoinManager _coinManager { get; set; }
        private CustomerManager _customerManager { get; set; }
        private AccountManager _accountManager { get; set; }
        public IMapper _mapper { get; set; }
        public AccountValidator _validator { get; set; }

        public AccountController(IMapper mapper, AccountValidator validator)
        {
            _coinManager = new CoinManager();
            _accountManager = new AccountManager();
            _customerManager = new CustomerManager();
            _validator = validator;
            _mapper = mapper;
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult CreateCustomer([FromBody] AccountDto accountDto)
        {
            try
            {
                if (accountDto == null || !_validator.Validate(accountDto).IsValid)
                {
                    var validations = new List<ValidationFailure>();

                    if (accountDto == null)
                    {
                        validations.Add(new ValidationFailure("Account", "The account can not be null"));
                    }
                    else
                    {
                        validations.AddRange(_validator.Validate(accountDto).Errors);
                    }

                    return new ErrorResult(Request, HttpStatusCode.BadRequest, validations);
                }

                var account = _mapper.Map<Account>(accountDto);
                var existingCustomer = _customerManager.RetrieveCustomer(new Customer() { Id = account.CustomerId });

                if (existingCustomer == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.BadRequest, new List<ValidationFailure>() {
                        new ValidationFailure("CustomerId", string.Format("The customer id: {0} does not exists", account.CustomerId))
                    });
                }

                var existingCoin = _coinManager.RetrieveCoin(new Coin() { Code = account.CoinCode });

                if (existingCoin == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.BadRequest, new List<ValidationFailure>() {
                        new ValidationFailure("CoinCode", string.Format("The coin code: {0} does not exists", account.CoinCode))
                    });
                }

                _accountManager.CreateAccount(account);
                var accounts = _accountManager.RetrieveAccountByCustomer(account);
                var newAccount = accounts.OrderBy(a => a.RegisteredAt)
                    .LastOrDefault();

                return Created(string.Format("{0}/accounts/{1}", Request.RequestUri, newAccount.Number),
                    _mapper.Map<AccountDto>(newAccount));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("{number}")]
        [HttpGet]
        public IHttpActionResult RetrieveAccount(string number)
        {
            try
            {
                var account = _accountManager.RetrieveAccount(new Account() { Number = number });

                if (account == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("Number", string.Format("The account number: {0} does not exists", account) )
                    });
                }

                return Ok(_mapper.Map<AccountDto>(account));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("customer")]
        [HttpGet]
        public IHttpActionResult RetrieveAccountByCustomer(string id)
        {
            try
            {
                var accounts = _accountManager.RetrieveAccountByCustomer(new Account() { CustomerId = id });

                return Ok(accounts.Select(account => _mapper.Map<AccountDto>(account)));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
