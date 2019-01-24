﻿using System;
using System.Runtime.Serialization;

namespace BLL
{
    [DataContract]
    public class OrderDTO
    {
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public DateTime Date { get; set; } = DateTime.Now;
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public string Class { get; set; }

        [DataMember]
        public int UserID { get; set; }
        [DataMember]
        public int FlightID { get; set; }

    }
}
