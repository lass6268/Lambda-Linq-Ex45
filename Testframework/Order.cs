using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testframework
{
    public class Order
    {
        public DG_BonusProvider Bonus { get; set; }

        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }
        public double GetValueOfProducts()
        {
            double valueOfProducts = 0.0;

            foreach (Product p in _products)
            {
                valueOfProducts += p.Value;
            }

            return valueOfProducts;
        }
        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }
        public double GetTotalPrice()
        {
            return GetValueOfProducts()-GetBonus(); ;
        }

        public double GetBonus(Func<double, double> tenPercent)
        {
            return tenPercent(GetValueOfProducts());
        }
    }
}
