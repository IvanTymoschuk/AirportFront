using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace BLL
{
    [DataContract]
    public class SendUser
    {
        [DataMember]
        public UserDTO user { get; set; }
        [DataMember]
        public string Messege { get; set; }
    }
}