using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFApp.Contracts
{
    [ServiceContract(Namespace = "http://www.arjun.com")]
    public interface IFruitService
    {
        [OperationContract]
        TomatoData GetTamoto();
    }
}
