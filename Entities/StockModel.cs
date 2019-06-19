namespace ConsoleJSONParse
{
    public class StockModel
    {
        public string manufacter { get; set; }
        public string model { get; set; }
        public string partNumber { get; set; }
        public string uaNumber { get; set; }
        public string serialNumber { get; set; }
        public string condition { get; set; }
        public string inShippingRef { get; set; }
        public string inShippingDate { get; set; }
        public string inLocation { get; set; }
        public string outShippingRef { get; set; }
        public string outShippingDate { get; set; }
        public string outLocation { get; set; }
        public string feeds { get; set; }
        public string localShippingRef { get; set; }
        public string localShippingDate { get; set; }
        public string cableOperator;
    }
}