using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public delegate void arithmeticOperation(int a, int b);

    public class mydelegate
    {
        public void Add(int a, int b)
        {
            Console.WriteLine("Addition is="+(a+b));
        }
        public void Sub(int a,int b)
        {
            Console.WriteLine("Subtraction is="+(a-b));
        }
        public void Mul(int a,int b)
        {
            Console.WriteLine("Multiplication is="+(a*b));
        }
    }
    internal class multicastdelegate1
    {
        static void Main()
        {
           


            mydelegate MD = new mydelegate();

            arithmeticOperation ao = new arithmeticOperation(MD.Add);
            ao += MD.Sub;
            ao += MD.Mul;

            
            ao(6, 2);
        }
    }
}
