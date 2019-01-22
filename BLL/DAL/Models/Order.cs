using System;

namespace DAL
{
    public class Order
    {
     
        public int ID { get; set; }
        public DateTime Date { get; set; }  = DateTime.Now;
        public decimal Price { get; set; }
        public string Class { get; set; }

        public virtual User user { get; set; }
        public virtual Flight flight { get; set; }

    }
}
