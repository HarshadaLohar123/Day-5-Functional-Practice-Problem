using System;

namespace Program
{
    public class LeapYear
    {
        int year;

        public static void Main(string[] args)
        {
            Console.WriteLine("Enter Year : ");
            int year = int.Parse(Console.ReadLine());

            if ((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0))
            {
                Console.WriteLine("is a LeapYear", year);
            }
            else
            {
                Console.WriteLine("not Leapyear", year);
                Console.ReadLine();
            }

        }
    }
}
