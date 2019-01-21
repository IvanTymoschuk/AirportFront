using System;

namespace DAL
{
    public class Order
    {
        public Order()
        {
            date = DateTime.Now;
        }
        public int ID { get; set; }
        public User user { get; set; }
        public Flight flight{ get; set; }
        public DateTime date;
        public decimal Price { get; set; }


    }
}
