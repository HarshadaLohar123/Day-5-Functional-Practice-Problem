using System;

namespace Program
{
    public class SwapTwoNumber
    {
        public static void Main(string[] args)
        {
            int a, b, c;


            Console.WriteLine("Enter the Value for A :");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Value for B :");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Value of A and B Before Swapping");
            Console.WriteLine("A : " + a + "\t" + "B : " + b);

            //Performing Sqpping logic using 3 Variables
            c = a;
            a = b;
            b = c;

            Console.WriteLine("Values of A and B After Swapping");
            Console.WriteLine("A : " + a + "\t" + "B : " + b);

        }
    }
}
