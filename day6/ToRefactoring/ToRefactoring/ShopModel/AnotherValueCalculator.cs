using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class AnotherValueCalculator : IComputationalLogic
    {
        public decimal ValueProducts(IEnumerable<Product> products)
        {
            decimal sumOfProduct = 0;
            foreach (var product in products)
            {
                sumOfProduct += product.Price;
            }
            return sumOfProduct/2;
        }
    }
}
