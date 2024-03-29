using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public class Apple : IProduct
    {
        public void DescribeProduct()
        {
            Console.WriteLine("This is an apple");
        }

        public string TypeOfTheProduct()
        {
            return "Apple is a fruit";
        }
    }
}
