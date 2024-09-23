using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class constantex
    {
        public int a = 10;
        public const double pi = 3.15485;
        public const string Appname = "Myapp";
        public string name="Test";

        public void PrintConstant()
        {
            Console.WriteLine($"The value of Pi is:{pi}");
            Console.WriteLine($"Application name:{Appname}");
            name = "Test1";
            Console.WriteLine(name);
        }
    }
    internal class ConstantExample
    {

        public static void Main() 
        { 
            constantex obj=new constantex();
            obj.PrintConstant();
        }
    }
}
