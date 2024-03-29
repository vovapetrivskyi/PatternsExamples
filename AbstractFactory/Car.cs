using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Car : IProduct
    {
        public void DisplayName()
        {
            Console.WriteLine("This is a car");
        }

        public decimal GetPrice()
        {
            return 10000m;
        }
    }
}
