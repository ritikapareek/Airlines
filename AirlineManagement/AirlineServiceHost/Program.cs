using System;
using System.Globalization;
using System.ServiceModel;
using System.ServiceModel.Description;
using Microsoft.Practices.Unity;
using Service;
using Service.AirlineNetwork;

namespace AirlineServiceHost
{
    class Program
    {
        static void Main()
        {
            using (var hostSoap = new ServiceHost(typeof(AirlineService)))
            using (var hostRest = new ServiceHost(typeof(AirlineServiceRest)))
            {
                hostSoap.Open();
                hostRest.Open();
                Console.WriteLine("Host Soap started @ " + DateTime.Now.ToString());
                Console.WriteLine("Host Rest started @ " + DateTime.Now.ToString());
                Console.ReadLine();

            }

        }
    }
}
