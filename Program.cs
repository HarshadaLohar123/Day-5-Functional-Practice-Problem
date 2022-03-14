using System;

namespace Program
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int number;
            int temp = 1;

            Console.WriteLine("Enter the Number :");
            number = int.Parse(Console.ReadLine());

            //For to get Prime Factor
            Console.WriteLine("The Prime Factors for Numbers " + number + " Are:");
            for (int i = 2; i <= number; i++)
            {
                if (number % i == 0)
                {
                    temp = 1;
                    for (int j = 2; j <= i / 2; j++)
                    {
                        if (i % j == 0)
                        {
                            temp = 0;
                            break;
                        }
                    }
                    if (temp == 1)
                    {
                        Console.WriteLine(i + " ");
                    }
                }
            }

        }
    }
}
