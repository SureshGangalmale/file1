using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class defaultConstructorEx
    {
        public int value;

        //default construcor
        public defaultConstructorEx()
        {
            value = 10;
        }
        public void Test()
        {
            Console.WriteLine("Test" + value);
        }
    }
    internal class defuiltConstructor
    {
       
        static void Main()
        {
            defaultConstructorEx obj=new defaultConstructorEx();
            Console.WriteLine(obj.value);
            obj.Test();
        }
    }
}
