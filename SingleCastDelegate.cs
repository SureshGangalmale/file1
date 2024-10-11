using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public delegate void addDelegate(int a,int b);  
    public delegate void subDelegate(int a,int b);

    class Delegate1
    {
        public void addNumber(int a,int b)
        {
            Console.WriteLine("Addition of Two numbers="+(a+b));
        }
        public void subNumber(int a,int b)
        {
            Console.WriteLine("Subtraction of two Numbers=" + (a - b));
        }
    }
    internal class SingleCastDelegate
    {
        static void Main()
        {
            Delegate1 delegate1 = new Delegate1();
            addDelegate ad = new addDelegate(delegate1.addNumber);
            ad(20, 40);

            subDelegate sd=new subDelegate(delegate1.subNumber);
            sd(100, 50);

        }
    }
}
