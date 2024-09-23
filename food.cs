using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace First
{
    internal class food
    {
        static void Main()
        {
            int choice;
            do
            {
                Console.WriteLine("--------------Menu--------------");
                Console.WriteLine("1.Burger\n2.Pizza.\n3.Salad.\n4.Exit");
                Console.Write("Enter your choice:");
                choice=int.Parse(Console.ReadLine());
                switch(choice)
                {
                    case 1:
                        Console.WriteLine("you are chosen Burger and its Prise is 200Rs. ");
                        break;
                    case 2:
                        Console.WriteLine("you are chosen Pizza and its Prise is 100Rs.");
                        break;
                    case 3:
                        Console.WriteLine("you are chosen Salad and its Prise is 300Rs. ");
                        break;
                }
            }while (choice != 4);
        }
    }
}
