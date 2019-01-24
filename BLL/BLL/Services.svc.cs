using DAL;
using System;
using System.Security.Cryptography;
using System.ServiceModel.Activation;
using System.Text;
using System.Web;
using System.Linq;
using System.Collections.Generic;

namespace BLL
{



    [AspNetCompatibilityRequirements(RequirementsMode
       = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Services : IServices
    {
        public SendUser Register(string lname, string fname, string email, DateTime birthdate, bool gender, string pass)
        {
            try
            {
                DBase _context = new DBase();
                foreach (var user in _context.Users)
                    if (user.Email == email)
                        return new SendUser() { Messege = "Email used", user = null };
                UserDTO u = new UserDTO()
                {
                    BirthDate = birthdate,
                    Email = email,
                    FName = fname,
                    Gender = gender,
                    LName = lname,
                    orders = null,
                    Password = pass
                };
                _context.Users.Add(Parser.ToUser(u));
                _context.SaveChanges();
                return new SendUser() { Messege = "OK", user = u };
            }
            catch (Exception)
            {
                return new SendUser() { Messege = "SERVER FATAL ERROR (#_#)", user = null };
            }

        }

        SendUser IServices.Login(string Email, string password)
        {
            try
            {
                DBase _context = new DBase();
                foreach (var user in _context.Users.Include("Orders"))
                {
                    if (user.Email == Email && user.Password == password)
                    {
                        return new SendUser() { Messege = "OK", user = Parser.ToUserDTO(user) };
                    }
                }
                return new SendUser() { Messege = "Accaunt not found", user = null };
            }
            catch(Exception)
            {
                return new SendUser() { Messege = "SERVER FATAL ERROR (#_#)", user = null };
            }
        }

        IEnumerable<FlightDTO> IServices.GetAllFlight()
        {
            try
            {
                DBase _context = new DBase();
                List<FlightDTO> flights = new List<FlightDTO>();
                foreach (var el in _context.Flights)
                    flights.Add(Parser.ToFlightDTO(el));
                return flights;
            }
            catch(Exception)
            {
                throw new Exception("SERVER ERROR");
            }
        }

        string IServices.SetCard(string Email, string Card)
        {
            try
            {

                DBase _context = new DBase();
                if (_context.Users.FirstOrDefault(x => x.Email == Email) != null)
                {
                    _context.Users.FirstOrDefault(x => x.Email == Email).Card = Card;
                    _context.SaveChanges();
                    return "CARD HAS BEEN SAVED";
                }
                 return "ACCAUNT WITH EMAIL: " + Email + " NOT FOUND";
            }
            catch (Exception)
            {
                return "SERVER FATAL ERROR (#_#)";
            }
        }

  

        SendOrder IServices.MakeOrder(string Email, string Card, int Class, int IdFlight)
        {
            IServices services = new Services();
            string msg = services.SetCard(Email, Card);
            if (msg == "CARD HAS BEEN SAVED")
            {
                DBase _context = new DBase();
                string _class;
                decimal _price;
                if (Class == 1)
                {
                    _class = "Price Econom";
                    _price = _context.Flights.FirstOrDefault(x => x.ID == IdFlight).PriceEconom;
                }
                else
                if (Class == 2)
                {
                    _class = "Price Standart";
                    _price = _context.Flights.FirstOrDefault(x => x.ID == IdFlight).PriceStandart;
                }
                else
                if (Class == 3)
                {
                    _class = "Price Bussines";
                    _price = _context.Flights.FirstOrDefault(x => x.ID == IdFlight).PriceBussines;
                }
                else
                    return new SendOrder { Messege = "INVALID CLASS", Order = null };
                OrderDTO order = new OrderDTO()
                {
                    Class = _class,
                    Date = DateTime.Now,
                    FlightID = _context.Flights.FirstOrDefault(x => x.ID == IdFlight).ID,
                    Price = _price,
                    UserID = _context.Users.FirstOrDefault(x => x.Email == Email).ID,
                };

                _context.Users.FirstOrDefault(x => x.Email == Email).orders.Add(Parser.ToOrder(order));
                _context.SaveChanges();
                return new SendOrder { Messege = "OK", Order = order };
            }
            else
            {
                return new SendOrder { Messege = "CARD NO SAVED", Order = null};
            }
        }

     

        FlightDTO IServices.GetFlightById(int ID)
        {
           try
            {
                DBase _context = new DBase();
                return Parser.ToFlightDTO(_context.Flights.FirstOrDefault(x => x.ID == ID));
            }
            catch(Exception)
            {
                return null;
            }
        }
    }
}
