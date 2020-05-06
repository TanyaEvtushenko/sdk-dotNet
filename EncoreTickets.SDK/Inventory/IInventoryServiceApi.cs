﻿using System;
using System.Collections.Generic;
using EncoreTickets.SDK.Api;
using EncoreTickets.SDK.Inventory.Models;
using EncoreTickets.SDK.Inventory.Models.RequestModels;

namespace EncoreTickets.SDK.Inventory
{
    /// <summary>
    /// The interface of an inventory service
    /// </summary>
    public interface IInventoryServiceApi : IServiceApi
    {
        /// <summary>
        /// Search for products by a keyword.
        /// GET /api/{VERSION}/search
        /// </summary>
        /// <param name="text">Search query</param>
        /// <returns>Products that contain a search query in their names</returns>
        IList<Product> SearchProducts(string text);

        /// <summary>
        /// Get the first and last bookable dates for a product.
        /// GET /api​/{VERSION}​/products​/{productId}​/availability-range
        /// </summary>
        /// <param name="productId">ID product</param>
        /// <returns>The first and last bookable dates for a product</returns>
        AvailabilityRange GetAvailabilityRange(int productId);

        /// <summary>
        /// Get the first and last bookable dates for a product.
        /// GET /api​/{VERSION}​/products​/{productId}​/availability-range
        /// </summary>
        /// <param name="productId">ID product, no longer than 50 chars might contain numbers, letters and dashes</param>
        /// <returns>The first and last bookable dates for a product</returns>
        AvailabilityRange GetAvailabilityRange(string productId);

        /// <summary>
        /// Get an array of performance availabilities.
        /// GET /api/{VERSION}/availability​/products​/{productId}​/quantity​/{quantity}​/from​/{fromDate}​/to​/{toDate}
        /// </summary>
        /// <param name="productId">ID product</param>
        /// <param name="quantity">quantity of seats needed</param>
        /// <param name="from">start date</param>
        /// <param name="to">end date</param>
        /// <returns>Array of performance availabilities</returns>
        IList<Availability> GetAvailabilities(int productId, int quantity, DateTime from, DateTime to);

        /// <summary>
        /// Get an array of performance availabilities.
        /// GET /api/{VERSION}/availability​/products​/{productId}​/quantity​/{quantity}​/from​/{fromDate}​/to​/{toDate}
        /// </summary>
        /// <param name="productId">ID product, no longer than 50 chars might contain numbers, letters and dashes</param>
        /// <param name="quantity">quantity of seats needed</param>
        /// <param name="fromDate">start date</param>
        /// <param name="toDate">end date</param>
        /// <returns>Array of performance availabilities</returns>
        IList<Availability> GetAvailabilities(string productId, int quantity, DateTime fromDate, DateTime toDate);

        /// <summary>
        /// Get available seats.
        /// GET /api​/{VERSION}​/europa​/availability​/products​/{productId}​/quantity​/{quantity}​/seats
        /// </summary>
        /// <param name="productId">ID product</param>
        /// <param name="quantity">quantity of seats needed</param>
        /// <param name="performance">performance: if nothing is sent, current time will be used</param>
        /// <returns>Array of availability seat</returns>
        SeatAvailability GetSeatAvailability(int productId, int quantity, DateTime? performance = null);

        /// <summary>
        /// Get available seats.
        /// GET /api​/{VERSION}​/europa​/availability​/products​/{productId}​/quantity​/{quantity}​/seats
        /// </summary>
        /// <param name="productId">ID product</param>
        /// <param name="quantity">quantity of seats needed</param>
        /// <param name="performance">performance: if nothing is sent, current time will be used</param>
        /// <returns>Array of availability seat</returns>
        SeatAvailability GetSeatAvailability(string productId, int quantity, DateTime? performance = null);

        /// <summary>
        /// Get available seats.
        /// GET /api​/{VERSION}​/europa​/availability​/products​/{productId}​/quantity​/{quantity}​/seats
        /// </summary>
        /// <param name="productId">ID product, no longer than 50 chars might contain numbers, letters and dashes</param>
        /// <param name="quantity">quantity of seats needed</param>
        /// <param name="date">performance date: if nothing is sent, current date will be used</param>
        /// <param name="time">performance time: if nothing is sent, current time will be used</param>
        /// <returns>Array of availability seat</returns>
        SeatAvailability GetSeatAvailability(string productId, int quantity, DateTime? date, DateTime? time);

        /// <summary>
        /// Get available seats.
        /// GET /api​/{VERSION}​/europa​/availability​/products​/{productId}​/quantity​/{quantity}​/seats
        /// </summary>
        /// <param name="productId">ID product, no longer than 50 chars might contain numbers, letters and dashes</param>
        /// <param name="quantity">quantity of seats needed</param>
        /// <param name="parameters">Optional parameters</param>
        /// <returns>Array of availability seat</returns>
        SeatAvailability GetSeatAvailability(string productId, int quantity, SeatAvailabilityParameters parameters);
    }
}