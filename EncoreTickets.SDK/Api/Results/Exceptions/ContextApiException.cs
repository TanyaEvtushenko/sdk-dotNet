﻿using System.Collections.Generic;
using System.Linq;
using EncoreTickets.SDK.Api.Context;
using EncoreTickets.SDK.Api.Results.Response;
using RestSharp;

namespace EncoreTickets.SDK.Api.Results.Exceptions
{
    /// <summary>
    /// The base exception for API requests with warnings in response contexts.
    /// </summary>
    public class ContextApiException : ApiException
    {
        /// <inheritdoc />
        public override List<string> Errors => GetContextErrorsAsStrings();

        public readonly IEnumerable<Info> ContextErrors;

        /// <summary>
        /// Initializes a new instance of <see cref="ContextApiException"/>
        /// </summary>
        public ContextApiException(IEnumerable<Info> infosAsErrors)
        {
            ContextErrors = infosAsErrors;
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ContextApiException"/>
        /// </summary>
        public ContextApiException(ContextApiException sourceException) : this(
            sourceException.ContextErrors,
            sourceException.Response,
            sourceException.Context,
            sourceException.ContextInResponse,
            sourceException.RequestInResponse)
        {
        }

        /// <summary>
        /// Initializes a new instance of <see cref="ContextApiException"/>
        /// </summary>
        public ContextApiException(
            IEnumerable<Info> infosAsErrors,
            IRestResponse response,
            ApiContext requestContext,
            Response.Context contextInResponse,
            Request requestInResponse)
            : base(response, requestContext, contextInResponse, requestInResponse)
        {
            ContextErrors = infosAsErrors;
        }

        private List<string> GetContextErrorsAsStrings()
        {
            return ContextErrors?.Select(ConvertInfoToString).ToList();
        }

        private static string ConvertInfoToString(Info info)
        {
            return string.IsNullOrEmpty(info.message) ? info.code : info.message;
        }
    }
}