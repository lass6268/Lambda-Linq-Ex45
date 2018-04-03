using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testframework

{
    

    public static class Bonuses
    {
        //Func<double, double> TenPercent1 = new Func<double, double>(TenPercent);
        public static double TenPercent (double amount)
        {
            return amount/10.0;
        }
        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            return amount > 5.0 ? 2.0 : 0.0;
        }
    }
}
