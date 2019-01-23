using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using DAL;
namespace BLL
{
    public static class Parser
    {
        public static UserDTO ToUserDTO(User u)
        {

            if (u.orders==null)
            {
                return new UserDTO()
                {
                    BirthDate = u.BirthDate,
                    Card = u.Card,
                    Email = u.Email,
                    FName = u.FName,
                    Gender = u.Gender,
                    ID = u.ID,
                    LName = u.LName,
                    orders = null,
                    Password = u.Password
                };
            }
            else
            {
                HashSet<OrderDTO> orders1 = new HashSet<OrderDTO>();
                foreach (var el in u.orders)
                    orders1.Add(ToOrderDTO(el));
                return new UserDTO()
                {
                    BirthDate = u.BirthDate,
                    Card = u.Card,
                    Email = u.Email,
                    FName = u.FName,
                    Gender = u.Gender,
                    ID = u.ID,
                    LName = u.LName,
                    orders  = orders1,
                    Password = u.Password
                };
            }


        }
        public static User ToUser (UserDTO u)
        {
            if (u.orders==null)
            {
                return new User()
                {
                    BirthDate = u.BirthDate,
                    Card = u.Card,
                    Email = u.Email,
                    FName = u.FName,
                    Gender = u.Gender,
                    ID = u.ID,
                    LName = u.LName,
                    orders = null,
                    Password = u.Password
                };
            }
            else
            {
                HashSet<Order> orders1 = new HashSet<Order>();
                foreach (var el in u.orders)
                    orders1.Add(ToOrder(el));
                return new User()
                {
                    BirthDate = u.BirthDate,
                    Card = u.Card,
                    Email = u.Email,
                    FName = u.FName,
                    Gender = u.Gender,
                    ID = u.ID,
                    LName = u.LName,
                    orders = orders1,
                    Password = u.Password
                };
            }

        }

        public static OrderDTO ToOrderDTO(Order o)
        {
            return new OrderDTO()
            {
                Class = o.Class,
                Date = o.Date,
                ID = o.ID,
                flight = ToFlightDTO(o.flight),
                Price = o.Price,
                user = ToUserDTO(o.user)
            };
        }

        public static Order ToOrder(OrderDTO o)
        {
            return new Order()
            {
                Class = o.Class,
                Date = o.Date,
                ID = o.ID,
                flight = ToFlight(o.flight),
                Price = o.Price,
                user = ToUser(o.user)
            };
        }

        public static FlightDTO ToFlightDTO(Flight f)
        {
            return new FlightDTO()
            {
                Count = f.Count,
                From = f.From,
                Date = f.Date,
                ID = f.ID,
                Plen = f.Plen,
                To = f.To,
                PriceBussines = f.PriceBussines,
                PriceEconom = f.PriceEconom,
                PriceStandart = f.PriceStandart
            };
        }

        public static Flight ToFlight(FlightDTO f)
        {
            return new Flight()
            {
                Count = f.Count,
                From = f.From,
                Date = f.Date,
                ID = f.ID,
                Plen = f.Plen,
                To = f.To,
                PriceBussines = f.PriceBussines,
                PriceEconom = f.PriceEconom,
                PriceStandart = f.PriceStandart
            };
        }

    }
}