using System;

namespace If_statements
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // The test that can be either true or false
            bool isMale = true;
            if (isMale)
            {
                Console.WriteLine("You are male");
            }
            else
            {
                Console.WriteLine("You are female");
            }

            // Can also test two conditions with 'and' (&&) or 'or' (||) in C#
            bool isTall = false;
            if (isTall && isMale)
            {
                Console.WriteLine("You are both male and tall");
            }
            else if (isTall && !isMale)  // Check if tall but not male
            {
                Console.WriteLine("You are tall but not male");
            }
            else if (!isTall && isMale)  // Check if not tall but male
            {
                Console.WriteLine("You are not tall but you are male");
            }
            else
            {
                Console.WriteLine("You are either not tall or not male");
            }

            Console.ReadLine();
        }
    }
}
