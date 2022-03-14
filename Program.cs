using System;

namespace Program
{
    public class HarmonicNumber 
    {
        public static void Main(string[] args)
        { 

            Console.WriteLine("Enter the Harmonic Value : ");
            int harmonicNo = int.Parse(Console.ReadLine());
            double total = 0;

            //Repeat until the Harmonic Sequence complete
            for (int i = 1; i <= harmonicNo; i++)
            {
                total += (double)1 / i;
                Console.WriteLine("1/" + i + "+");
            }
            Console.WriteLine("\nTotal of Harmonic Number :" + total);

        }
    }
}
