using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class paraConstructor
    {
        public string name { get; set; }
        public int Age { get; set; }

        public paraConstructor(string Name,int age) 
        {
            name = Name;
            Age = age;
        }
        public void Display()
        {
            Console.WriteLine($"Name:{name},Age:{Age}");
        }
    }
    internal class ParameterConsructor
    {
        static void Main()
        {
            paraConstructor obj=new paraConstructor("Suresh",21);
            obj.Display();

        }
    }
}
