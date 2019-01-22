﻿using System;
namespace DAL
{
    public class Flight
    {
        public int ID { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        public int Count { get; set; }
        public string Plen { get; set; }
    }
}
