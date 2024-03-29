using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Potato : IProduct
    {
        public void DisplayName()
        {
            Console.WriteLine("This is a potato");
        }

        public decimal GetPrice()
        {
            return 15m;
        }
    }
}
