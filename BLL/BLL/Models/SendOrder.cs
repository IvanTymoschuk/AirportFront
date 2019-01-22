using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BLL.Models
{
    [DataContract]
    public class SendOrder
    {
        [DataMember]
        public OrderDTO Order { get; set; }
        [DataMember]
        public string Messege { get; set; }
    }
}