using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class CarFactory : IAbstractFactory
    {
        public IBuilding CreateBuilding()
        {
            return new CarMarket();
        }

        public IProduct CreateProduct()
        {
            return new Car();
        }
    }
}
