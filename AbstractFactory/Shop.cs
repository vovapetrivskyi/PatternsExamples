using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    public class Shop : IBuilding
    {
        public void DisplayName()
        {
            Console.WriteLine("This is a shop");
        }
    }
}
