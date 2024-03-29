using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factory
{
    public abstract class ProductFactory
    {
        public abstract IProduct CreateProduct();

        public void DisplayInformationAboutProduct()
        {
            var product = CreateProduct();

            product.DescribeProduct();
        }

        public string GetProductType()
        {
            var product = CreateProduct();

            return product.TypeOfTheProduct();
        }
    }
}
