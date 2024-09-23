using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class BaseClass
    {
       // private int privateField;
        protected int protectedField=10;
        public int publicField = 10;
        public void setField(int value,int Public)
        {
            //privateField= value;
            protectedField= value;
            publicField= Public;

            Console.WriteLine("private field=" + protectedField);
           
        }
    }
    class derivedClass:BaseClass 
    {
        public int Display()
        {
            Console.WriteLine("Display"+protectedField);
            return 1;
        }
    }   
    class DerivedClass : BaseClass
    {
        public void show()
        {
            Console.WriteLine("Show" + protectedField);
            Console.WriteLine("public field=" + publicField);
        }
    }
     class Protected
    { 
        public static void Main()
        {
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.setField(12,10);
            derivedClass.show();
           


        }
    }
}
