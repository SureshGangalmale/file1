using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class ArrayList1
    {
        static void Main()
        {
            //creating object of an array list
            ArrayList list= new ArrayList();

            //adding elements in to array list

            list.Add(4);
            list.Add(40);
            list.Add(300);
            list.Add(4000);
            list.Add(34.45);
            list.Add('S');
            list.Add("Suresh");
            list.Add("Amol");
            list.Add("Om");
            list.Add("Sunil");

            Console.WriteLine("Array list Element Added");

            //Display All Element in Array list
            foreach(var items in list)
            {
                Console.WriteLine(items);
            }
            //Remove one element in Array list
            list.Remove('S');
            Console.WriteLine("Remove one Element in Array List");

            foreach (var items in list)
            {
                Console.WriteLine(items);
            }

            //remove All Element in Array list
            list.Clear();

            foreach(var items in list)
            {
                Console.WriteLine(items);
            }
            Console.WriteLine("Delete All Element in Array List");
        }
    }
}
