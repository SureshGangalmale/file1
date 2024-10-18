using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class one
    {
        public void Add()
        {
            int a = 40; int b = 20;
            int c = a + b;
            Console.WriteLine("Addition is ="+c);
        }

    }
    sealed class  Two: one
    {

        public void Sub()
        {
            int a = 40; int b = 20;
            int c = a - b;
            Console.WriteLine("Subtraction is ="+c);
        }
    }
    internal class SealedClass1
    {
        static void Main()
        {
            Two obj1=new Two();
            obj1.Add();
            obj1.Sub();
        }
    }
}
