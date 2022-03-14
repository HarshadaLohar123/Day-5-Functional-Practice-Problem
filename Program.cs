using System;

namespace Program
{
    public class QuotientOrRemainder
    {
        public static void Main(string[] args)
        {
            //Variable Declaration
            int dividend, divisor, quotient, remainder;

            Console.WriteLine("Enter the Value of Dividend :");
            dividend = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the Value of Divisor :");
            divisor = int.Parse(Console.ReadLine());

            //Formula to get Quotient Or Remainder
            quotient = dividend / divisor;
            remainder = dividend % divisor;

            //Displaying the value of Quotient Or Remainder
            Console.WriteLine("Quotient =" + quotient);
            Console.WriteLine(("Remainder =" + remainder));

        }
    }
}
