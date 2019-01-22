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

        SendUser IServices.Login(string Email, string password)
        {
            DBase _context = new DBase();
            foreach (var user in _context.Users)
            {
                if (user.Email == Email && user.Password == password)
                {
                    return new SendUser() { Messege = "OK", user = Parser.ToUserDTO(user) };
                }
            }
            return new SendUser() { Messege = "Accaunt not found", user = null };
        }

        IEnumerable<FlightDTO> IServices.GetAllFlight()
        {
            DBase _context = new DBase();
            List<FlightDTO> flights = new List<FlightDTO>();
            foreach (var el in _context.Flights)
                flights.Add(Parser.ToFlightDTO(el));
            return flights;
        }
    }
}
