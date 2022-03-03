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
    [RoutePrefix("api/coins")]
    public class CoinController : ApiController
    {
        private CoinManager _coinManager { get; set; }
        private SuscriptorManager _suscriptorManager { get; set; }
        public IMapper _mapper { get; set; }
        public CoinValidator _validator { get; set; }
        
        public CoinController(IMapper mapper, CoinValidator validator)
        {
            _coinManager = new CoinManager();
            _validator = validator;
            _mapper = mapper;
        }

        [Route("")]
        [HttpPost]
        public IHttpActionResult CreateCoin(CoinDto coinDto)
        {
            try
            {
                if (coinDto == null || !_validator.Validate(coinDto).IsValid)
                {
                    var validations = new List<ValidationFailure>();

                    if (coinDto == null)
                    {
                        validations.Add(new ValidationFailure("Coin", "The coin can not be null"));
                    }
                    else
                    {
                        validations.AddRange(_validator.Validate(coinDto).Errors);
                    }

                    return new ErrorResult(Request, HttpStatusCode.BadRequest, validations);
                }

                var coin = _mapper.Map<Coin>(coinDto);
                var existingSuscriptor = _suscriptorManager.RetrieveSuscriptor(new Suscriptor() { Code= coin.FintechCode });

                if (existingSuscriptor == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.Conflict, new List<ValidationFailure>() {
                        new ValidationFailure("FintechCode", string.Format("The fintech code: {0} does not exists", coinDto.FintechCode))
                    });
                }

                var existingCoinByFintech = _coinManager.RetrieveCoinByFintech(coin);

                if (existingCoinByFintech != null)
                {
                    return new ErrorResult(Request, HttpStatusCode.Conflict, new List<ValidationFailure>() {
                        new ValidationFailure("FintechCode", string.Format("The fintech code: {0} already has an existing coin", coinDto.FintechCode))
                    });
                }

                _coinManager.CreateCoin(coin);
                var newCoin = _coinManager.RetrieveCoinByFintech(coin);

                return Created(string.Format("{0}/coins/{1}", Request.RequestUri, newCoin.Code),
                    _mapper.Map<CoinDto>(newCoin));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("{code}")]
        [HttpGet]
        public IHttpActionResult RetrieveCoin(int code)
        {
            try
            {
                var coin = _coinManager.RetrieveCoin(new Coin() { Code = code });

                if (coin == null)
                {
                    return new ErrorResult(Request, HttpStatusCode.NotFound, new List<ValidationFailure>() {
                        new ValidationFailure("Coin", string.Format("The coin code: {0} does not exists", code) )
                    });
                }

                return Ok(_mapper.Map<CoinDto>(coin));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }

        [Route("fintech")]
        [HttpGet]
        public IHttpActionResult RetrieveCoinByFintech(string code)
        {
            try
            {
                var coin = _coinManager.RetrieveCoinByFintech(new Coin() { FintechCode = code });

                return Ok(_mapper.Map<CoinDto>(coin));
            }
            catch (Exception)
            {
                return InternalServerError();
            }
        }
    }
}
