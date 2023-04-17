using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionary2
{
    public static class Margin
    {
        public static List<double> AddPrice(List<double> startingPrice)
        {
            List<double> totalPrice = new List<double>() { };

            foreach (int i in startingPrice)
            {
                totalPrice[i] = startingPrice[i] * 1.18;
                Console.Write("   " + totalPrice[i]);
            }

            return totalPrice;
        }    
    }
}


