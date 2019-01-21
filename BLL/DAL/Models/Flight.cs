using System;
namespace DAL
{
    public class Flight
    {
        public Flight()
        {
            date = DateTime.Now;
        }
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime date { get; set; }
        public int Count { get; set; }
        public string Plen { get; set; }
    }
}
