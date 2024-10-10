using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Exception1
    {
        static void Main()
        {
            //DivideByZeroException
            try
            {
                int num1 = 10;
                int num2 = 0;
                int result = checked(num1 / num2);
                
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can not divide by Zero");
            }

            //OverFlowException
            try
            {
                int num1 = int.MaxValue;
                int result = checked(num1 + 1);
                Console.WriteLine(result);
            }
            catch(OverflowException ex)
            {
                Console.WriteLine("Can not add number");
            }

            //FormatException

            try
            {
                string validDate = "2024-10-05";
                DateTime Date = DateTime.Parse(validDate);
                Console.WriteLine(Date);
                string invalidDate = "not-a-valid";
                DateTime inDate = DateTime.Parse(invalidDate);
                Console.WriteLine(inDate);
                
            }
            catch(FormatException ex)
            {
                Console.WriteLine("invalid date format");
            }


        }
    }
}
