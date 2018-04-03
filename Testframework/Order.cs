using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testframework
{
    public class Order
    {
        public Func<double,double> Bonus { get; set; }

        private List<Product> _products = new List<Product>();

        public void AddProduct(Product p)
        {
            _products.Add(p);
        }
        public double GetValueOfProducts()
        {

            return _products.Sum(x => x.Value);

            
        }
        public double GetValueOfProducts(DateTime dateTime)
        {

            //return _products.Where(x => x.AvailableFrom <= dateTime && x.AvailableTo >= dateTime).Sum(x=>x.Value);
            return _products.Sum(x => x.AvailableFrom <= dateTime && x.AvailableTo >= dateTime ? x.Value : 0);

        }
        public double GetBonus()
        {
            return Bonus(GetValueOfProducts());
        }
        public double GetTotalPrice()
        {
            return GetValueOfProducts()-GetBonus(); ;
        }

        public double GetBonus(Func<double, double> bonus)
        {
            return bonus(GetValueOfProducts());
        }
        public double GetTotalPrice(Func<double, double> bonus)
        {

            return GetValueOfProducts() - GetBonus(bonus);
        }

        public double GetTotalPrice(DateTime dateTime, Func<double, double> bonus)
        {
            return GetValueOfProducts(dateTime) - GetBonus(bonus,dateTime);
        }
        public double GetBonus(Func<double, double> bonus, DateTime dateTime)
        {
            return bonus(GetValueOfProducts(dateTime));
        }
    }
}
