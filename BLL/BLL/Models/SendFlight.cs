using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BLL
{
    [DataContract]
    public class SendFlight
    {
        [DataMember]
        public FlightDTO Flight { get; set; }
        [DataMember]
        public string Messege { get; set; }
    }
}