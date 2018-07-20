using System;

namespace Lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                long input = GetInput();
                DisplayAnswer(GetFactorial(input), input);
            } while (Continue());
            Console.Read();
        }

        static long GetInput()
        {
            while (true)
            {
                Console.WriteLine("Please enter an integer from 1 to 25.");
                if (Int64.TryParse(Console.ReadLine(), out long input) &&
                    input >= 1 && input <= 25)
                {
                    return input;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                }
            }
        }

        static void DisplayAnswer(long factorial, long input)
        {
            //will display the factorial
            Console.WriteLine($"Factorial: {factorial}, Input: {input}");
        }

        static long GetFactorial(long input)
        {
            if (input == 1)
            {
                return 1;
            }
            else
            {
                return input * GetFactorial(input - 1);
            }
        }

        static bool Continue()
        {
            while (true)
            {
                Console.Write("Continue? (y/n): ");
                String input = Console.ReadLine().ToLower();
                if (input == "y" || input == "yes")
                {
                    return true;
                }
                else if (input == "n" || input == "no")
                {
                    return false;
                }
                Console.WriteLine("Invalid input.");
            }
        }
    }
}
