using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class ReadOnlyEx
    {
        public readonly int frstValue;
        public static readonly double pi;

        public ReadOnlyEx(int firstValue)
        {
            frstValue = firstValue;
            frstValue = 20;
        }
        static ReadOnlyEx()
        {
            pi = 3.2345;
        }
        public void printValue()
        {
            Console.WriteLine($"First value:{frstValue}");
            Console.WriteLine($"value of Pi:{pi}");
        }
    }
    internal class ReadOnlyExample
    {
        static void Main()
        {
            ReadOnlyEx obj=new ReadOnlyEx(10);
            obj.printValue();

        }
    }
}
