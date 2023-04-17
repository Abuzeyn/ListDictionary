using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionary
{
    public static class PremiumCalculation
    {
        public static int CalculateMaxRating(List<int> rating)
        {

            int maxRating = rating[0];

            foreach (int i in rating)

            {
                if (maxRating < i)
                {
                    maxRating = i;
                }
            }
            return maxRating;
        }
    }
}
    
               

            
                
