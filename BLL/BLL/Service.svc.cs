using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;

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
              UriTemplate = "/API/Register?Email={Email}&pass={pass}&salt={salt}&balance={balance}")]
        bool Register(string lname, string fname, string email, string birtdate, string Card, bool gender);

        [OperationContract]
        [WebInvoke(Method = "GET",
         RequestFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Wrapped,
             ResponseFormat = WebMessageFormat.Json,
         UriTemplate = "/API/Login?Email={Email}&password={password}")]
        bool Login(string Email, string password);
    }
}
