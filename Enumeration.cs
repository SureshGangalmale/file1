using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Enumeration
    {
        public enum days
        {
            Sunday,
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday
        }
        enum HTTPStatusCode
        {
            ok=200,
            BadRequest=400,
            Unauthorized=401,
            forbiden=500,
            NotFound=400
           
        }
        public static void Main()
        {
            //Console.BackgroundColor= ConsoleColor.White;
            Console.WriteLine("-----------------------------------Enumeration in C#------------------------------");

            days today = days.Monday;
            Console.BackgroundColor = ConsoleColor.Magenta;

            switch (today)
            {
                case days.Sunday:
                    Console.WriteLine("Today is Sunday");
                    break;
                case days.Monday:
                    Console.WriteLine("Today is Monday");
                    break;
                case days.Tuesday:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case days.Wednesday:
                    Console.WriteLine("Today is Wednesday");
                    break;
                
            }
            if(today ==days.Sunday || today==days.Saturday)
            {
                Console.WriteLine("Its  Weekend");

            }
            else
            {
                Console.WriteLine("its week days");
            }

            Console.BackgroundColor= ConsoleColor.Red;

            HTTPStatusCode code = HTTPStatusCode.BadRequest;
            Console.WriteLine("HTTP status code:" + code);

            int codenumber=(int)code;
            Console.WriteLine("HTTP StatusCode status code number=" + codenumber);
        }
    }
}
