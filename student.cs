using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class student
    {
        static void Main()
        {
            //For Loop
            Console.WriteLine("--------------For Loop------------------");
            for(int i = 1;i<= 10;i++)
            {
                Console.Write(" Student-"+i);
            }
            Console.WriteLine();
            //While Loop
            Console.WriteLine("--------------While Loop------------------");
            int j = 1;
            while ( j <= 10)
            {
                Console.Write(" Student-" + j);
                j++;
            }
            Console.WriteLine();
            //do-While Loop
            Console.WriteLine("--------------Do-While Loop------------------");
            int k = 1;
            do
            {
                Console.Write(" Student-" + k);
                k++;
            }while( k <= 10);
            Console.WriteLine();
            Console.WriteLine();

            
        }
    }
}
