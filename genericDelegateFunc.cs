using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class genericDelegateFunc
    {
        //Func Delegate
        public static string Addstring(string str1, string str2)
        {
            return $"{str1} {str2}";
        }

        public static string check(int a,string str)
        {
            if (a > 0)
            {
                 str = "Number is positive";
            }
            else if(a < 0)
            {
                str = "Number is Negative";
            }
            else
            {
                str = "Number is Zero";
            }
            return str;
            
        } 

        //predicate Delegate

        public static bool alphabet(string b)
        {
            if('a' == b[0])
            {
                return true;
            }
            return false;
        }

        //Action Delegate

        public static void Message(string str)
        {
            Console.WriteLine(str);
        }

        public static void timeStamp(string str,string ErrorMessage)
        {
            Console.WriteLine($"{DateTime.Now}:{ErrorMessage}");
        }
        static void Main()
        {

            //Func Delegate
            //concate two strings
            Func<string, string, string> obj1 = Addstring;
            string concate = obj1.Invoke("CodeMind", "Technology");
            Console.WriteLine(concate);

            //check number is Positive,Zero,Negative
            Func<int, string, string> obj2= check;
            Console.WriteLine(obj2.Invoke(34,""));

            //Predicate
            //Compare first letter
            Predicate<string> obj3 = alphabet;
            bool status=obj3.Invoke("Apple");
            Console.WriteLine(status);

            //Action Delegate
            // Print simple message on a Console
            Action<string> obj4 = Message;
            obj4.Invoke("This is Action Delegate in C#");


            Action<string,string> obj5 = timeStamp;
            obj5.Invoke("","An unexpected error occurred.");
        }
    }
}
