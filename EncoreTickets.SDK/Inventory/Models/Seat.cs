﻿namespace EncoreTickets.SDK.Inventory.Models
{
    public class Seat
    {
        public string SeatIdentifier { get; set; }

        public string AggregateReference { get; set; }

        public string ItemReference { get; set; }

        public string Row { get; set; }

        public int? Number { get; set; }

        public bool? IsAvailable { get; set; }

        public Attributes Attributes { get; set; }

        public Pricing Pricing { get; set; }

        public AggregateReference AggregateReferenceObject { get; set; }
    }
}