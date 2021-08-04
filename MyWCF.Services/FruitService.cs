using MyWCFApp.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyWCFApp.Services
{
    public class FruitService : IFruitService
    {
        public TomatoData GetTamoto()
        {
            TomatoData tomato = new TomatoData()
            {
                Id = 1,
                Name = "Cherry"
            };
            return tomato;
        }
    }
}
