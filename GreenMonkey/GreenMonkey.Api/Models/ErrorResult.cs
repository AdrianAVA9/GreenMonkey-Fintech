using FluentValidation.Results;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity.Validation;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Http.ModelBinding;

namespace GreenMonkey.Api.Models
{
    public class ErrorResult : IHttpActionResult
    {
        private HttpRequestMessage Request { get; }
        private readonly HttpStatusCode _statusCode;
        private readonly ModelStateDictionary _errors;

        private ErrorResult(HttpRequestMessage request, HttpStatusCode statusCode)
        {
            Request = request;
            _statusCode = statusCode;
        }

        public ErrorResult(HttpRequestMessage request, HttpStatusCode statusCode, ModelStateDictionary errors) : this(request, statusCode)
        {
            _errors = errors;
        }

        public ErrorResult(HttpRequestMessage request, HttpStatusCode statusCode, ICollection<ValidationFailure> errors) : this(request, statusCode)
        {
            if (errors == null)
                throw new ArgumentNullException("The errors can not be null");

            _errors = new ModelStateDictionary();
            foreach (var error in errors)
            {
                _errors.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }

        public ErrorResult(HttpRequestMessage request, HttpStatusCode statusCode, ICollection<DbValidationError> errors) : this(request, statusCode)
        {
            if (errors == null)
                throw new ArgumentNullException("The errors can not be null");

            _errors = new ModelStateDictionary();
            foreach (var error in errors)
            {
                _errors.AddModelError(error.PropertyName, error.ErrorMessage);
            }
        }

        public void AddError(string key, string errorMessage)
        {
            _errors.AddModelError(key, errorMessage);
        }

        public Task<HttpResponseMessage> ExecuteAsync(CancellationToken cancellationToken)
        {
            return Task.FromResult(Request.CreateErrorResponse(_statusCode, _errors));
        }
    }
}