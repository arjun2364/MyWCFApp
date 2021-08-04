using MyWCFApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFApp.ConsoleHost
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(FruitService));
            host.Open();
            Console.WriteLine("Host is up and running.......");
            Console.ReadLine();
            host.Close();
        }
    }
}
