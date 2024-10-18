using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class out1
    {
        static void InitializeValue(out int number,out string Message)
        {
            number = 1;
            Message = "Welcome to CodeMind Technology";
        }
        static void Main()
        {
            InitializeValue(out int value, out string str);
            Console.WriteLine($"{value}\n{str}");
        }
    }
}
