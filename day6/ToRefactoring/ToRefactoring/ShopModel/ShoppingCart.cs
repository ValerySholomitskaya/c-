using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopModel
{
    public class ShoppingCart
    {
      //  private ValueCalculator valueCalc;

        public IEnumerable<Product> Products { get; set; }

        /*
        public ShoppingCart()
        {
            valueCalc = new ValueCalculator();

        }
         что с этим делать
*/
        public decimal CalculateProductTotal(IComputationalLogic logic, IDiscount discount)
        {
            return logic.ValueProducts(Products) - logic.ValueProducts(Products)*discount.Discount();
        }
    }
}
