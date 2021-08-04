using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFApp.Client2
{
    [ServiceContract(Namespace = "http://www.arjun.com")]
    public interface IFruitService
    {
        [OperationContract]
        TomatoData GetTamoto();
    }

    [DataContract]
    public class TomatoData
    {
        [DataMember]
        public string Name { get; set; }
    }
}
