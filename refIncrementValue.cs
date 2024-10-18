using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
   
    internal class refIncrementValue
    {
        public static void increment(ref int a)
        {
            a++;
            Console.WriteLine("value is incremented...");
            Console.WriteLine("value is=" + a);
        }
        public static void Main()
        {
            int n = 2;
            increment(ref n);
            increment(ref n);
            increment(ref n);
        }
    }
}
