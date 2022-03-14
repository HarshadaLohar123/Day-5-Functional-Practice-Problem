using System;

namespace Program
{
    public class PowerOfTwo
    {
        public static void Main(string[] args)
        {
            //Accepting Command Line Argument Value in Variable
            int n = int.Parse(args[0]);

            Console.WriteLine("Number for Power : " + n);

            //Checking for Validation of Power No
            if (n <= 0 || n > 31)
            {
                Console.WriteLine("The Power Number must be Greater Than Zero and Less Than 31");
            }
            else
            {
                //Repeat untill i less than or equals to N
                for (int i = 1; i <= n; i++)
                {
                    //Use Math Power Function to calculate the Power of Number
                    int powerOfNo = (int)Math.Pow(2, i);
                    Console.WriteLine(powerOfNo);
                    Console.ReadLine();
                }
            }
        }
    }
}
