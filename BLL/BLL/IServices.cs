using System;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Collections.Generic;

namespace BLL
{

    [ServiceContract]

    public interface IServices
    {

        [OperationContract]
        [WebInvoke(Method = "GET",
              RequestFormat = WebMessageFormat.Json,
              ResponseFormat = WebMessageFormat.Json,
              BodyStyle = WebMessageBodyStyle.Wrapped,
              UriTemplate = "/API/Auth/Register?lname={lname}&fname={fname}&email={email}&birthdate={birthdate}&gender={gender}&pass={pass}")]
        SendUser Register(string lname, string fname, string email, DateTime birthdate, bool gender,string pass);

        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Wrapped,
             ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/API/Auth/Login?Email={Email}&password={password}")]
        SendUser Login(string Email, string password);


        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Wrapped,
           ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/API/Data/GetAllFlight")]
        IEnumerable<FlightDTO> GetAllFlight();

        [OperationContract]
        [WebInvoke(Method = "GET",
       RequestFormat = WebMessageFormat.Json,
       BodyStyle = WebMessageBodyStyle.Wrapped,
         ResponseFormat = WebMessageFormat.Json,
       UriTemplate = "/API/Data/SET/SetCard?Email={Email}&Card={Card}")]
       string SetCard(string Email, string Card);

        [OperationContract]
        [WebInvoke(Method = "GET",
      RequestFormat = WebMessageFormat.Json,
      BodyStyle = WebMessageBodyStyle.Wrapped,
        ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/API/Data/SET/MakeOrder?Email={Email}&Card={Card}&Class={Class}&IdFlight={IdFlight}")]
        SendOrder MakeOrder(string Email, string Card, int Class, int IdFlight);
    }
}
