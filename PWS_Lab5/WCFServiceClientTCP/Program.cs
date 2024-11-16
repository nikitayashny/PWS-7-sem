using PWS_Lab5;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WCFServiceClient.Client;

namespace WCFServiceClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string binding = "tcpEndpoint";

            WCFSiplexClient simplexClient = new WCFSiplexClient(binding);

            Console.WriteLine("Method add for int and int: " + simplexClient.Add(1, 2));

            Console.WriteLine("Method concat for str and double: " + simplexClient.Concat("qwe", 1));

            A a = simplexClient.Sum(new A { f = 1.1f, k = 1, s = "qwe" }, new A { f = 2.4f, k = 2, s = "zxc" });
            Console.WriteLine($"Result of sum object: f = {a.f} k = {a.k} s = {a.s}");

            Console.ReadKey();
            simplexClient.Close();

        }
    }
}
