﻿
using System.Collections.Generic;


namespace DAL
{
    public class User
    {
        public User()
        {
            orders = new List<Order>();
        }
        public int ID { get; set; }
        public string LName { get; set; }
        public string FName { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public bool Gender { get; set; }
        public string  Card { get; set; }
        public List<Order> orders { get; set; }
    }
}