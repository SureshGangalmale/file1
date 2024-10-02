using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class hashTable
    {
        static void Main()
        {
            Hashtable myHashtable=new Hashtable();

            //add key-value paring to the hashtable

            myHashtable.Add(121, "amol");
            myHashtable.Add(123, "satyavan");
            myHashtable.Add(124, "Suresh");
            myHashtable.Add(125, "Om");
            myHashtable.Add(126, "Sunil");

            //accessing the element although typecasting

            /*string value1 = (string)myHashtable[121];
           string value2 = (string)myHashtable[123];
           string value3= (string)myHashtable[124];
           string value4 = (string)myHashtable[125];
           string value5 = (string)myHashtable[126];

           //display value

          Console.WriteLine($"121:{value1}");
           Console.WriteLine($"123:{value2}");
           Console.WriteLine($"124:{value3}");
           Console.WriteLine($"125:{value4}");
           Console.WriteLine($"126:{value5}");*/


            //Add Five element in Hashtable
            foreach (DictionaryEntry items in myHashtable)
            {
                Console.WriteLine(items.Key + " " + items.Value);
            }
            //Change value "Om" to "Mahesh" in HashTable
            Console.WriteLine();
            Console.WriteLine("Change value in Hashtable");
            Console.WriteLine();
            myHashtable[125] = "Mahesh";

            foreach(DictionaryEntry items in  myHashtable)
            {
                Console.WriteLine(items.Key + " "+items.Value);
            }

            //Remove one Element in Hashtable.
            myHashtable.Remove(123);
            Console.WriteLine();
            Console.WriteLine("delete one Element  in Hashtable");
            foreach (DictionaryEntry items in myHashtable)
            {
                Console.WriteLine(items.Key + " " + items.Value);
            }

            //Delete All Five element in Hashtable
            myHashtable.Clear();

            foreach (DictionaryEntry items in myHashtable)
            {
                Console.WriteLine(items.Key + " " + items.Value);
            }
        }
    }
}
