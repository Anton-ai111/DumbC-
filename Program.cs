using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a number to divide by:");
            int divisor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The result of dividing {0} by {1} is {2}", number
            , divisor, number / divisor);
        }
    }
}