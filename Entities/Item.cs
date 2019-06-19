namespace ConsoleJSONParse
{
    using System;
    public class Item
    {
        public string GUID { get; set; }

        public string Type { get; set; }

        public string Version { get; set; }

        public string Status { get; set; }

        public string PackageName { get; set; }

        public string Pieces { get; set; }

        public string Description { get; set; }

        public string Length { get; set; }

        public string Height { get; set; }

        public string Width { get; set; }

        public string Weight { get; set; }

        public string ContainedPiecesWeightIncluded { get; set; }

        public string Volume { get; set; }

        public string VolumeWeight { get; set; }

        public string PieceWeight { get; set; }

        public string PieceVolume { get; set; }

        public string PieceQuantity { get; set; }

        public string IsSummarized { get; set; }

        public string SerialNumber { get; set; }

        public string SupplierPONumber { get; set; }

        public string Model { get; set; }

        public string PartNumber { get; set; }

        public string WarehouseReceiptGUID { get; set; }

        public string OutShipmentGUID { get; set; }

        public string WHRItemID { get; set; }

        public string IncludeInSED { get; set; }

        public string IsContainer { get; set; }

        public string OutMasterWayBillNumber { get; set; }

        public string OutHouseWayBillNumber { get; set; }

        public string LastReceptionNetworkID { get; set; }

        public string ShipmentType { get; set; }

        public DateTime OutDate { get; set; }

        public string WarehouseReceiptNumber { get; set; }

        public string OrderIndex { get; set; }

        public string IsPallet { get; set; }

        public string IsOverstock { get; set; }

        public string NotLoaded { get; set; }

        public string InTask { get; set; }

        public PreviousLocation PreviousLocation { get; set; }

        public DateTime EntryDate { get; set; }

        public CustomFields CustomFields { get; set; }    }
}