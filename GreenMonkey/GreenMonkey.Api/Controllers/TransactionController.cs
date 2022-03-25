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
    [RoutePrefix("api/transactions")]
    public class TransactionController : ApiController
    {
        private AccountManager _accountManager { get; set; }
        private TransactionManager _transactionManager { get; set; }
        public TransactionValidator _validator { get; set; }
        public IMapper _mapper { get; set; }
        
        public TransactionController(IMapper mapper, TransactionValidator validator)
        {
            _accountManager = new AccountManager();
            _transactionManager = new TransactionManager();
            _validator = validator;
            _mapper = mapper;
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult CreateTransaction(TransactionDto transactionDto)
        {
            try
            {
                if (transactionDto == null || !_validator.Validate(transactionDto).IsValid)
                {
                    var validations = new List<ValidationFailure>();

                    if (transactionDto == null)
                    {
                        validations.Add(new ValidationFailure("Transaction", "The Transaction can not be null"));
                    }
                    else
                    {
                        validations.AddRange(_validator.Validate(transactionDto).Errors);
                    }

                    return new ErrorResult(Request, HttpStatusCode.BadRequest, validations);
                }

                var transaction = _mapper.Map<Transaction>(transactionDto);
                var existingAccount = _accountManager.RetrieveAccount(new Account() { Number = transaction.UBAN });

                if (existingAccount == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.Conflict, new List<ValidationFailure>() {
                        new ValidationFailure("AccountNumber", string.Format("The account number: {0} does not exists", transaction.UBAN))
                    });
                }

                _transactionManager.CreateTransaction(transaction);
                var transactions = _transactionManager.RetrieveTransactionsByAccount(transaction);
                var newTrasaction = transactions.OrderBy(t => t.Id)
                    .LastOrDefault();

                return Created(string.Format("{0}/transactions/{1}", Request.RequestUri, newTrasaction.Id),
                    _mapper.Map<TransactionDto>(newTrasaction));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("{id}")]
        [HttpGet]
        public IHttpActionResult RetrieveTransaction(int id)
        {
            try
            {
                var transaction = _transactionManager.RetrieveTransaction(new Transaction() { Id = id });

                if (transaction == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("Id", string.Format("The transaction id: {0} does not exists", id) )
                    });
                }

                return Ok(_mapper.Map<TransactionDto>(transaction));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("account")]
        [HttpGet]
        public IHttpActionResult RetrieveTransactionsByAccount(string number)
        {
            try
            {
                var transactions = _transactionManager.RetrieveTransactionsByAccount(new Transaction() { UBAN = number });

                return Ok(transactions.Select(transaction => _mapper.Map<TransactionDto>(transaction)));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
