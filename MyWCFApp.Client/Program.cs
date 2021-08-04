using MyWCFApp.Proxies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFApp.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            FruitClient fruit = new FruitClient("http");
            var x = fruit.GetTamoto();
            Console.WriteLine(x.Name);
            EndpointAddress endpointAddress = new EndpointAddress("http://localhost:8500/fruits");
            Binding binding = new BasicHttpBinding();
            FruitClient fruit2 = new FruitClient(binding, endpointAddress);
            var x2 = fruit2.GetTamoto();
            Console.WriteLine(x2.Name);
            Console.ReadLine();
        }
    }
}
