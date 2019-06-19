namespace ConsoleJSONParse
{
    using System;
    public class Event
    {
        public DateTime Date { get; set; }

        public EventDefinition EventDefinition { get; set; }

        public string IncludeInTracking { get; set; }

        public string OwnerType { get; set; }

        public string OwnerNumber { get; set; }

        public string OwnerGUID { get; set; }
    }
}