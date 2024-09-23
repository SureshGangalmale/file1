using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    public class copyConstructorEx
    {
        public string name { get; set; }
        public int Age { get; set; }

        public string NameNew { get; set; }

        public int AgeNew { get; set; }

        public copyConstructorEx(string Name, int age)
        {
            name = Name;
            Age = age;
        }
        public copyConstructorEx(copyConstructorEx copyex)
        {
            NameNew = copyex.name;
            AgeNew= copyex.Age;
        }
        public void Display()
        {
            Console.WriteLine($"Name:{name},Age:{Age}");
        }

        public void DisplayNew()
        {
            Console.WriteLine($" New Name:{NameNew},New Age:{AgeNew}");
        }
    }
    internal class CopyConstructor
    {
        static void Main()
        {
            copyConstructorEx obj = new copyConstructorEx("Suresh", 21);
            obj.Display();

            copyConstructorEx obj2 = new copyConstructorEx(obj);
            obj2.DisplayNew();
        }
    }
}
