using System;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please type a number: ");
            string numberAsString = Console.ReadLine();
            int parsedValue;

            bool success = int.TryParse(numberAsString, out parsedValue);

            if (success)
            {
                Console.WriteLine("Parsing successful - the number is {0}", parsedValue);
            }
            else
            {
                Console.WriteLine("Parsing failed! the value \"{0}\" is not a valid number!",numberAsString);
            }
                

            Console.Read();
        }
    }
}
