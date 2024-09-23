using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class Array
    {
        static void Main()
        {
            //Declare the Array
            string[] mobile = new string[4];

            //Asigning values

            mobile[0] = "Apple";
            mobile[1] = "Motorola";
            mobile[2] = "Realme";
            mobile[3] = "Vivo";

            //Access arrays value
            Console.WriteLine("Mobiles in Array index: ");

            //foreach loop
            foreach (string mobiles in mobile)
            {
                Console.WriteLine(mobiles);
            }

            //for loop

            for (int i = 0; i < mobile.Length; i++)
            {
                Console.WriteLine(mobile[i]);
            }

            //Reverse Array

            int[] numbers = { 1, 2, 3, 4, 5 };
            //print original array

            print(numbers);
            //reverse numbers

            Reverse(numbers);

            Console.WriteLine("Print Reverse array");

            print(numbers);

            Console.WriteLine("------------------------------------Multidimentional Array-----------------------------------------------");

            //Initialise Multidimensional Array

            int[,] matrix = new int[,]
            {
                {1,2,3},
                {4,5,6},
                {7,8,9}
            };

            //accessing the element from array

            Console.WriteLine("Element at (0,0) :" + matrix[0, 0]);//1
            Console.WriteLine("Element at (1,2) :" + matrix[1, 2]);

            //print all the element in array.
            Console.WriteLine("________________________________________________________________________________________________________________________________");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(matrix[i, j]);
                }
                Console.WriteLine();
            }

            //Jagged Array
            Console.WriteLine("-------------------Jaggged array-----------------------------------");
            //declaration of jagged array
            int[][] jaggedArray = new int[][]
            {
                new int[]{1,2},
                new int[]{3,4,5},
                new int[]{6,7,8,9}
            };

            Console.WriteLine("element at[0][1]" + jaggedArray[0][1]);
            Console.WriteLine("element at[2][3]" + jaggedArray[2][3]);

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                for(int j = 0; j < jaggedArray[i].Length; j++)
                {
                    Console.Write(jaggedArray[i][j]+" ");
                }
                Console.WriteLine();
            }

            //String
            Console.WriteLine("--------------------String------------------------");
            string str = "Hello World!";
            Console.WriteLine(str);
            str = "test";
            Console.WriteLine(str);

            //more memory Space
            string firstname = "Suresh";
            string lastName = "Gangalmale";
            string name = firstname + lastName;
            Console.WriteLine(name);

            //String Builder
            //creating object for string Builder
            Console.WriteLine("----------------------String Builder-----------------");
            StringBuilder sb=new StringBuilder();
            sb.Append("Hello");
            sb.Append(",");
            sb.Append("World!");
            sb.Remove(3, 5);
           

            //to add the specific index

           // sb.Insert(5,"there");

            //replace a String

            sb.Replace("World!", "C# Developer");
            string result = sb.ToString();
            Console.WriteLine(result);

            sb.Clear();

            //boxing

            int number = 30; //Value type (int).
            object obj = number; //Boxing it will convert value to object(reference)

            //unboxing

            object objn = 15;//boxed integer value.
            int num1 = (int)objn;
            Console.WriteLine(num1 + "  " + obj);


            

        }
        public static void print(int[] arr)
        {
            foreach (var num in arr)
            {
                Console.WriteLine(num + " ");
            }

        }
        public static void Reverse(int[] arr)
        {
            int start = 0;
            int end = arr.Length - 1;

            while (start < end)
            {
                //element swapping
                int temp = arr[start];
                arr[start] = arr[end];
                arr[end] = temp;
                start++;
                end--;
            }
            int r = 10, s = 5;
            Console.WriteLine("Addition is=" + (r + s));
        }



    }
}
