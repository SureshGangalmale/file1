using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    class person
    {
        public string Name="suresh";
        public int Age=21;
    }
    class Student : person
    {
         public Student()
        {

            Console.WriteLine("Name is = " + Name + "\nAge is = "+Age);
        }
    }
    internal class studentInfo
    {
        static void Main()
        {
            Student s1 = new Student();
        }
    }
}
