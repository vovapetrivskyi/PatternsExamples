using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Potato : IProduct
    {
        public void DescribeProduct()
        {
            Console.WriteLine("This is a potato");
        }

        public string TypeOfTheProduct()
        {
            return "Potato is a vegatable";
        }
    }
}
