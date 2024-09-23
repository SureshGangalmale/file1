using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class statements
    {
        static void Main()
        {
            //if Statement
            /* Console.WriteLine("------if Statement----------");
             int number = 0;
             if (number == 0)
             {
                 Console.WriteLine("Number is Zero");
             }
             //if-else Statement
             Console.WriteLine("--------if-else Statement------------");
             if(number>0)
             {
                 Console.WriteLine("Number is Positive");
             }
             else
             {
                 Console.WriteLine("Number is Negative");
             }

             //if-else-if Statement
             if (number > 0)
             {
                 Console.WriteLine("Number is negative");
             }
             else if(number <0)
             {
                 Console.WriteLine("number is Positive");
             }
             else
             {
                 Console.WriteLine("Number is Zero");
             }

             //Switch Statement
             int day = 3;
             switch (day)
             {
                 case 1:
                     Console.WriteLine("Monday");
                     break;
                 case 2:
                     Console.WriteLine("Tuesday");
                     break;
                 case 3:
                     Console.WriteLine("Wednesday");
                     break;
                 case 4:
                     Console.WriteLine("Thrsday");
                     break;
                 default:
                     Console.WriteLine("Other Day");
                     break;
             }
            */
            //Looping in C#

            //for Loop
            /*
           for(int i = 0; i < 10; i++)
            {
                Console.WriteLine("iteration:" + i);
            }

            //while Loop- Entry Control Loop
            int n = 1;
            while (n <= 5)
            {
                Console.WriteLine("hello." + n);
                n++;
            }

            //do-while Loop-Exit control Loop

            int j = 0;
            do
            {
                Console.WriteLine("Bye."+j);
                j++;
            }while(j < 3);
            Console.WriteLine("_____________________________________________________________________________________");

            int option;
            
            do
            {
                Console.WriteLine("1.Add.\n2.Sub\n3.Mul.\n4.div.5.exit");
                Console.WriteLine("Enter Operation..");
                option=int.Parse(Console.ReadLine());
                switch(option)
                {
                    case 1:
                        Console.WriteLine("1 number:");
                        int a=int.Parse(Console.ReadLine());
                        Console.WriteLine("2 number:");
                        int b = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------");
                        Console.WriteLine("Addition is="+(a+b));
                        Console.WriteLine("----------------");
                        break;
                    case 2:
                        Console.WriteLine("1 number:");
                        int c = int.Parse(Console.ReadLine());
                        Console.WriteLine("2 number:");
                        int d = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------");
                        Console.WriteLine("subtraction is=" +(c - d));
                        Console.WriteLine("----------------");
                        break;
                    case 3:
                        Console.WriteLine("1 number:");
                        int e = int.Parse(Console.ReadLine());
                        Console.WriteLine("2 number:");
                        int f = int.Parse(Console.ReadLine());
                        Console.WriteLine("----------------");
                        Console.WriteLine("Multiplication is=" + (e * f));
                        Console.WriteLine("----------------");
                        break;
                    case 4:
                        Console.WriteLine("1 number:");
                        int g = int.Parse(Console.ReadLine());
                        Console.WriteLine("2 number:");
                        int h = int.Parse(Console.ReadLine());
                        Console.WriteLine("divide is=" + (g / h));
                        break;
                }

            }while(option != 5);*/

            //For Each Loop

            string[] fruits = { "Apple", "Orange", "grapes", "Banana", "Kivi", "Mango", "Strawberry", "Watermelon" };
            foreach (string fruit in fruits)
            {
                Console.WriteLine("The fruit name is=" + fruit);
            }
            //there are 3 majar Jumping statement.
            //1.break 2.continue 3.goto

            //continue statement

            for (int i = 0; i < 5; i++)
            {
                if(i == 2)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            //Go-To Statement

            int cnt = 0;
            startloop:
            if (cnt < 5)
            {
                Console.WriteLine($"count is {cnt}");
                cnt++;
                goto startloop;
            }
            Console.WriteLine("Loop with goto is finished");

            // break Statement
            int num = 2;
            switch (num)
            {
                case 1:
                    Console.WriteLine("one");
                    break;
                case 2:
                    Console.WriteLine("two");
                    goto case 3;
                case 3:
                    Console.WriteLine("three");
                    break;
            }

        }
    }
}
