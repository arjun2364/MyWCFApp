using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFApp.Client2
{
    class Program
    {
        static void Main(string[] args)
        {
            ChannelFactory<IFruitService> channelFactory = new ChannelFactory<IFruitService>("");
            IFruitService service = channelFactory.CreateChannel();

            var x = service.GetTamoto();
            Console.WriteLine(x.Name);
            Console.ReadLine();
        }

        /*public TomatoData GetTamoto()
        {
            return Channel.GetTamoto();
        }*/
    }
}
