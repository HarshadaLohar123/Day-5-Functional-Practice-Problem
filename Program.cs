using System;

namespace LargestNumber
{
    public class LargestFrom3Number
    {
        public static void Main(string[] args)
        {
            int a, b, c;


            Console.WriteLine("Enter the 3 Numbers :");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());

            //Checking for the Largest Value using nested if-else
            if (a > b)
            {
                if (a > c)
                {
                    Console.WriteLine("The Value of A is Large : "+a);
                }
                else
                {
                    Console.WriteLine("The Value of C is Large : "+c);
                }
            }
            else
            {
                if (b > c)
                {
                    Console.WriteLine("The Value of B is Large : "+b);
                }
                else
                {
                    Console.WriteLine("The Value of C is Large : "+c);
                }
            }
        }
    }
}
