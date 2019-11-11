﻿using EncoreTickets.SDK.Api.Context;
using EncoreTickets.SDK.Api.Helpers;
using EncoreTickets.SDK.Basket.Models;
using EncoreTickets.SDK.EntertainApi;

namespace EncoreTickets.SDK.Basket
{
    /// <summary>
    /// The wrapper class for the Basket service API.
    /// </summary>
    public class BasketServiceApi : BaseEntertainApi
    {
        /// <summary>
        /// Default constructor for the Basket service.
        /// </summary>
        /// <param name="context">The API context for requests.</param>
        public BasketServiceApi(ApiContext context) : base(context, "basket-service.{0}tixuk.io/api/")
        {
        }

        /// <summary>
        /// Get details of a promotion by its ID. 
        /// </summary>
        /// <param name="promotionId"></param>
        /// <returns>Details of a promotion with the specified ID or null if not found.</returns>
        public Promotion GetPromotionDetails(string promotionId)
        {
            var path = $"v1/promotions/{promotionId}";
            var result = Executor.ExecuteApi<Promotion>(path, RequestMethod.Get, true);
            return result?.Data;
        }

        /// <summary>
        /// Get details of a basket by its reference. 
        /// </summary>
        /// <param name="basketReference"></param>
        /// <returns>Details of a basket with the specified reference or null if not found.</returns>
        public BasketDetails GetBasketDetails(string basketReference)
        {
            var path = $"v1/baskets/{basketReference}";
            var result = Executor.ExecuteApi<BasketDetails>(path, RequestMethod.Get, true);
            return result?.Data;
        }
    }
}
