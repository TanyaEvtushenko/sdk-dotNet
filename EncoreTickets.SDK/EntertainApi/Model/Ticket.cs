﻿using System;
using System.Collections.Generic;


namespace EncoreTickets.SDK.EntertainApi.Model
{
    public class Ticket
    {
        public string Block { get; set; }
        public string BlockDescription { get; set; }
        public string BlockId { get; set; }
        public DateTime Date { get; set; }
        public bool Discounted { get; set; }
        public decimal FaceValue { get; set; }
        public string First { get; set; }
        public string Last { get; set; }
        public string Performance { get; set; }
        public decimal Price { get; set; }
        public bool IsRestrictedView { get; set; }
        public string Row { get; set; }
        public string SeatKey { get; set; }
        public List<string> SeatLumps { get; set; }
        // public Dictino SeatOptions { get; set; }
        public string Seats { get; set; }
        public int ShowId { get; set; }
        public decimal Total { get; set; }

        #region Helper Properties & Methods

        public string DateFormatted
        {
            get { return Date.ToString("ddd, ") + Date.Date.Day.ToString() + Date.ToString(" MMM yyyy"); }
        }

        public bool Enta
        {
            get
            {
                return !string.IsNullOrEmpty(SeatKey) && SeatKey.ToLower().StartsWith("enta");
            }
        }

        public string FaceValueFormatted
        {
            get { return string.Format("{0:C}", FaceValue); }
        }

        public int FirstAsInt
        {
            get
            {
                int firstAsInt;

                return int.TryParse(First, out firstAsInt) ? firstAsInt : 0;
            }
        }

        public int LastAsInt
        {
            get
            {
                int lastAsInt;

                return int.TryParse(Last, out lastAsInt) ? lastAsInt : 0;
            }
        }
        
        public string PriceFormatted
        {
            get { return string.Format("{0:C}", Price); }
        }

        public string SavingAsPercentageFormatted
        {
            get
            {
                return "5%";
            }
        }

        public string Tag
        {
            get { return BlockId + ":" + Block.Replace(" ", ""); }
        }

        public string TimeFormatted
        {
            get { return Date.ToString("h:mmtt").ToLower(); }
        }

        #endregion
    }
}