using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class FoodFactory : IAbstractFactory
    {
        public IBuilding CreateBuilding()
        {
            return new Shop();
        }

        public IProduct CreateProduct()
        {
            return new Potato();
        }
    }
}
