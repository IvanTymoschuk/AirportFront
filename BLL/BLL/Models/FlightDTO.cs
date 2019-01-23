using System;
using System.Runtime.Serialization;

namespace BLL
{
    [DataContract]
    public class FlightDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string From { get; set; }
        [DataMember]
        public string To { get; set; }
        [DataMember]
        public DateTime Date { get; set; } = DateTime.Now;
        [DataMember]
        public int Count { get; set; }
        [DataMember]
        public string Plen { get; set; }
        [DataMember]
        public decimal PriceEconom { get; set; }
        [DataMember]
        public decimal PriceStandart { get; set; }
        [DataMember]
        public decimal PriceBussines { get; set; }
    }
}
