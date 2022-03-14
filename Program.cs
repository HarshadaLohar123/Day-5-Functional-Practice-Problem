using System;

namespace HeadOrTails
{
    public class FlipCoin
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Program for Counting the Percentile of Head and Tail");

            //Variables declaration
            int headCount = 0;
            int tailCount = 0;
            Random r = new Random();
            for (int i = 1; i <= 10; i++)
            {

                //Generating Random Flip of Coin
                double coinFlip = (r.Next() * 10) % 1;

                Console.WriteLine("Coin Flip Value =" + coinFlip);

                //Counting the Head and Tail Occurance
                if (coinFlip < 0.5)
                {
                    tailCount++;
                }
                else
                {
                    headCount++;
                }
            }

            //Print Head & Tail Counts
            Console.WriteLine("TailCount:" + tailCount);
            Console.WriteLine("HeadCount:" + headCount);

            //Calculating Percentage of Head vs Tail
            int PercentTail = (tailCount * 100) / 10;
            int PercentHead = (headCount * 100) / 10;

            //Printing Percentage of Head vs Tail
            Console.WriteLine("The Percentage of Tails is : " + PercentTail);
            Console.WriteLine("The Percentage of Heads is : " + PercentHead);

        }
    }
}
