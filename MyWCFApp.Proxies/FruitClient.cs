using MyWCFApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFApp.Proxies
{
    public class FruitClient : ClientBase<IFruitService>, IFruitService
    {
        public FruitClient(string endpointName): base(endpointName)
        {

        }

        public FruitClient(Binding binding, EndpointAddress address) : base(binding, address)
        {

        }
        public TomatoData GetTamoto()
        {
            return Channel.GetTamoto();
        }
    }
}
