
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace BLL
{
    [DataContract]
    public class UserDTO
    {
        public UserDTO()
        {
            orders = new HashSet<OrderDTO>();
        }
        [DataMember]
        public int ID { get; set; }
        [DataMember]
        public string LName { get; set; }
        [DataMember]
        public string FName { get; set; }
        [DataMember]
        public string BirthDate { get; set; }
        [DataMember]
        public string Email { get; set; }
        [DataMember]
        public bool Gender { get; set; }
        [DataMember]
        public string Card { get; set; }
        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public virtual ICollection<OrderDTO> orders { get; set; }
    }
}
