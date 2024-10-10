using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace First
{
    internal class CustomException
    {
        public static void Main(string[] args)
        {
            try
            {
                Console.Write("Enter a positive integer: ");
                int number = int.Parse(Console.ReadLine());

                if (number < 0)
                {
                    throw new NegativeNumberException();  
                }

                Console.WriteLine("You entered a valid positive integer: " + number);
            }
            catch (NegativeNumberException ex)
            {
                Console.WriteLine("Error: " + ex.Message);  
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: Invalid input, please enter an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
        }
        public class NegativeNumberException : Exception
        {
            public NegativeNumberException() : base("Negative numbers are not allowed.")
            {
            }

            public NegativeNumberException(string message) : base(message)
            {
            }
        }
    }
}

