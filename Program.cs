using System;

namespace EvenOdd
{
    public class EvenOrOdd
    {
        public static void Main(string[] args)
        {
            int number;

            Console.WriteLine("Enter Any Number :");
            number = int.Parse(Console.ReadLine());

            //Checking for Even or Odd Number using Mod Operator
            if (number % 2 == 0)
            {
                Console.WriteLine("The Number " + number + " is Even.");
            }
            else
            {
                Console.WriteLine("The Number " + number + " is Odd.");
            }

        }
    }
}
