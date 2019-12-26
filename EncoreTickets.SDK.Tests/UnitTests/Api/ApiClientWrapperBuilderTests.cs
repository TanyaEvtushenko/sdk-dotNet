﻿using System.Collections.Generic;
using System.ComponentModel;
using EncoreTickets.SDK.Api.Context;
using EncoreTickets.SDK.Api.Helpers;
using EncoreTickets.SDK.Api.Helpers.ApiRestClientBuilder;
using EncoreTickets.SDK.Tests.Helpers;
using EncoreTickets.SDK.Utilities.Common.RestClientWrapper;
using EncoreTickets.SDK.Utilities.Common.Serializers;
using EncoreTickets.SDK.Utilities.Enums;
using NUnit.Framework;

namespace EncoreTickets.SDK.Tests.UnitTests.Api
{
    internal class ApiClientWrapperBuilderTests
    {
        private const string SdkVersion = "2.4.0";

        private static TestCaseData[] sourceForCreateClientWrapperTests =
        {
            new TestCaseData(new ApiContext()) {TestName = "Empty API context"},
            new TestCaseData(null) {TestName = "NULL API context"},
        };

        private static object[] sourceForCreateClientWrapperParametersTests =
        {
            new object[]
            {
                new ApiContext(),
                RequestMethod.Get,
                new {test1 = "test", Test2 = 4, test3 = (string) null},
                new Dictionary<string, string>
                {
                    {"x-SDK", $"EncoreTickets.SDK.NET {SdkVersion}"},
                },
                new Dictionary<string, string>
                {
                    {"test1", "test"},
                    {"test2", "4"},
                }
            },
            new object[]
            {
                new ApiContext
                {
                    Affiliate = "test"
                },
                RequestMethod.Get,
                null,
                new Dictionary<string, string>
                {
                    {"x-SDK", $"EncoreTickets.SDK.NET {SdkVersion}"},
                    {"affiliateId", "test"},
                },
                null
            },
        };

        [TestCase(true, TestName = "NULL API context")]
        [TestCase(false, TestName = "Empty API context")]
        public void Api_ApiClientWrapperBuilder_CreateClientWrapper_ReturnsClientWrapper(bool contextShouldBeNull)
        {
            var context = contextShouldBeNull ? null : new ApiContext();

            var wrapper = new ApiRestClientBuilder().CreateClientWrapper(context);

            Assert.NotNull(wrapper);
        }

        [TestCaseSource(nameof(sourceForCreateClientWrapperParametersTests))]
        public void Api_ApiClientWrapperBuilder_CreateClientWrapperParameters_ReturnsCorrectedParameters(
            ApiContext context, RequestMethod method, object queryObject,
            Dictionary<string, string> expectedHeaders, Dictionary<string, string> expectedQuery)
        {
            var baseUrl = "url";
            var endpoint = "resource endpoint";
            var body = new object();
            var parameters = new ExecuteApiRequestParameters
            {
                Endpoint = endpoint,
                Body = body,
                Method = method,
                Query = queryObject
            };
            var expectedParameters = new RestClientParameters
            {
                BaseUrl = baseUrl,
                RequestUrl = endpoint,
                RequestBody = body,
                RequestFormat = RequestFormat.Json,
                RequestMethod = method,
                RequestUrlSegments = null,
                RequestHeaders = expectedHeaders,
                RequestQueryParameters = expectedQuery,
                Serializer = new DefaultJsonSerializer(),
                Deserializer = new DefaultJsonSerializer()
            };

            var result = new ApiRestClientBuilder().CreateClientWrapperParameters(context, baseUrl, parameters);

            AssertExtension.AreObjectsValuesEqual(expectedParameters, result);
        }
    }
}
