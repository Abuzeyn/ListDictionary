using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListDictionary3
{
    public static class ListOfNames
    {
        public static void WriteOutLessPlan( Dictionary<string, int> namesEndSales, int salesPlan)
        {

            foreach (KeyValuePair<string, int> item in namesEndSales)
            {

                if (item.Value < salesPlan)
                {

                    Console.WriteLine(item.Key);
                    
                }
            }
        }
    }
}


                 



                













