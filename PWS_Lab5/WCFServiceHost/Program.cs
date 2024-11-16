using System;
using System.ServiceModel;
using PWS_Lab5;

namespace WCFServiceHost
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(WCFSiplex)))
            {
                host.Open();
                Console.WriteLine("WCF Service Host is running. Press Enter to close.");
                Console.ReadLine();
            }
        }
    }
}