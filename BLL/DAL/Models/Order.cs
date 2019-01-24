using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace DAL
{
    public class Order
    {
     
        public int ID { get; set; }
        public DateTime Date { get; set; }  = DateTime.Now;
        public decimal Price { get; set; }
        public string Class { get; set; }

        public int UserID { get; set; }
 
        public int FlightID { get; set; }

    }
}
