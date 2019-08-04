using System;
using System.Globalization;
using System.ServiceModel;
using Microsoft.Practices.Unity;
using Service;
using Service.AirlineNetwork;

namespace AirlineServiceHost
{
    class Program
    {
        static void Main()
        {
            using (ServiceHost host = new ServiceHost(typeof(AirlineService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();

            }
        }
    }
}
