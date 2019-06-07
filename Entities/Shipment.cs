namespace ConsoleJSONParse
{
    using System;
    using System.Collections.Generic;
    public class Shipment
    {
        public DateTime createdOn { get; set; }

        public string number { get; set; }

        public string createdByName { get; set; }

        public string shipperName { get; set; }

        public ShipperAddress shipperAddress { get; set; }

        public string consigneeName { get; set; }

        public ConsigneeAddress consigneeAddress { get; set; }

        public List<Item> items { get; set; }

        public Events events { get; set; }

        public string totalPieces { get; set; }

        public string totalWeight { get; set; }

        public string totalVolume { get; set; }

        public string status { get; set; }

        public DateTime estimatedArrivalDate { get; set; }

        public DateTime estimatedDepartureDate { get; set; }
    }
}