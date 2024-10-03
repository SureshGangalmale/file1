using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace First
{
    internal class NonGenStack
    {
        static void Main()
        {
            

            Console.WriteLine("-------Nongeneric collection Stack---------");
            Stack stack = new Stack();
            stack.Push("Suresh");
            stack.Push(42);
            stack.Push("amol");
            stack.Push(44);
            stack.Push("Om");

            foreach(object item in stack)
            {
                Console.Write("\t"+item);
            }
            Console.WriteLine();
            stack.Pop();
            foreach(object item in stack)
            {
                Console.Write("\t"+item);
            }
            Console.WriteLine();
            stack.Clear();
            Console.WriteLine(stack.Count);
            Console.WriteLine("-------Nongeneric collection Queue---------");

            Queue queue = new Queue();
            queue.Enqueue("Amol");
            queue.Enqueue("Satyavan");
            queue.Enqueue("Mahesh");
            queue.Enqueue(21);

            foreach(object item in queue)
            {
                Console.Write("\t"+item);
            }

            queue.Dequeue();

            foreach(object item in queue)
            {
                Console.Write("\t"+item);
            }
            Console.WriteLine();
            queue.Clear();
            Console.WriteLine(queue.Count);

            Console.WriteLine("-------generic collection list---------");

            List<object> list = new List<object>();
            list.Add(34.34);
            list.Add("Pune");
            list.Add("Mumbai");
            list.Add("Solapur");

            foreach(object item in list)
            {
                Console.Write("\t"+item);
            }

            list.Remove("Pune");

            foreach(object item in list)
            {
                Console.Write("\t"+item);
            }
            Console.WriteLine();
            list.Clear();
            Console.WriteLine(list.Count);

            Console.WriteLine("-------generic collection Dictionary---------");
            
            Dictionary<string,int> dict = new Dictionary<string,int>();


            dict.Add("Shambhu", 78);
            dict.Add("Satyavan", 89);
            dict.Add("Amol", 80);
            dict.Add("Mahesh", 90);
            dict.Add("sunil", 87);
            dict.Add("Sushant", 85);
            dict.Add("Rohan", 90);
            dict.Add("aknath", 89);
            dict.Add("Samadhan", 97);
            dict.Add("Tushar", 87);

            foreach(KeyValuePair<string,int> item in dict)
            {
                Console.WriteLine(item.Key+ ":" + item.Value);
            }

            dict["Rohan"] = 85;
            Console.WriteLine("Modified item");
            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.Write("\t"+item.Key + ":" + item.Value);
            }
            dict.Remove("aknath");
            Console.WriteLine();
            Console.WriteLine("remove Specific  item");

            foreach (KeyValuePair<string, int> item in dict)
            {
                Console.Write("\t" + item.Key + ":" + item.Value);
            }

            Console.WriteLine("\nFilter element\n");

            if (dict.ContainsKey("Mahesh"))
            {
                Console.WriteLine("Exist\n");
            }
            Console.WriteLine("before:"+dict.Count);
            dict.Clear();

            Console.WriteLine("After:"+dict.Count);

            Console.WriteLine("-------Generic Collection Stack---------");

            Stack<int> stack1= new Stack<int>();

            stack1.Push(1);
            stack1.Push(2);
            stack1.Push(3);
            stack1.Push(4);
            stack1.Push(5);

            foreach(object item in stack1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("items in stack="+stack1.Count);

            stack1.Pop();
            stack1.Pop();
            Console.WriteLine("items in stack" + stack1.Count);

            foreach(object item in stack1)
            {
                Console.WriteLine(item);
            }

            stack1.Clear();

            foreach (object item in stack1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(stack1.Count);


            Console.WriteLine("-------Generic Collection Queue---------");

            Queue<int> queue1 = new Queue<int>();

            queue1.Enqueue(1);
            queue1.Enqueue(2);
            queue1.Enqueue(3);
            queue1.Enqueue(4);
            queue1.Enqueue(5);

            foreach (object item in queue1)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("items in queue=" + queue1.Count);

            queue1.Dequeue();
            queue1.Dequeue();
            Console.WriteLine("items in queue=" + queue1.Count);

            foreach (object item in queue1)
            {
                Console.WriteLine(item);
            }

            queue1.Clear();

            foreach (object item in queue1)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine(queue1.Count);
        }
    }
}
