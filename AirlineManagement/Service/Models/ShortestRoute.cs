using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace Service.Models
{
    [DataContract]
    public class ShortestRoute
    {
        [DataMember]
        public List<string> ShortestRoutes { get; set; }

        public ShortestRoute(params string[] list)
        {
            ShortestRoutes = new List<string>(list);
        }
    }
}
