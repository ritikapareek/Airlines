using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;
using Service.Models;

namespace Service.AirlineNetwork
{
    [ServiceContract]
    public interface IAirlineService
    {
        [OperationContract]
      
        List<string> GetRoutes(string source, string destination);
     
    }

    [ServiceContract]
    public interface IAirlineServiceRest
    {
       
        [OperationContract]
        [WebInvoke(Method = "GET", ResponseFormat = WebMessageFormat.Json,

        BodyStyle = WebMessageBodyStyle.Wrapped, UriTemplate = "GetRoutesViaAPI?source={source}&destination={destination}")]
        ShortestRoute GetRoutesViaAPI(string source, string destination);
    }
}
