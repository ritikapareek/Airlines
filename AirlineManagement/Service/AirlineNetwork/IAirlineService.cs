using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace Service.AirlineNetwork
{
    [ServiceContract]
    public interface IAirlineService
    {
        [OperationContract]
        [WebGet]
       
        List<string> GetRoutes(string source, string destination);
    }
}
