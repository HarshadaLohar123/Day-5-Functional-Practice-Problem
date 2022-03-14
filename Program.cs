using System;

namespace AlphabetProgram
{
    public class VowelOrConsonant
    {
        public static void Main(string[] args)
        {
            char ch;
        
            Console.WriteLine("Enter Any Character :");
            string input = Console.ReadLine();
            ch = Convert.ToChar(input.ToLower());

            //Checking for Character is Vowel or Consonant
            if (ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            {
                Console.WriteLine(ch + " is Vowel");
            }
            else
            {
                Console.WriteLine(ch + " is Consonant");
            }

        }
    }
}
