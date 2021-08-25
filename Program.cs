using System;
using System.Collections.Generic;


namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Difficulty 1 - Easy, 2 - Medium, 3 - Hard");
            int difficulty = int.Parse(Console.ReadLine());

            var guesses = new List<int>
            {
                7, 5, 3
            };

            Random random = new Random();
            int SecretNumber = random.Next(1, 100);

            int NumOfGuess = guesses[difficulty - 1];

            Console.WriteLine("Guess a number!");
            Console.Write("Enter Guess ");

            int GuessedNumber = int.Parse(Console.ReadLine());
            // int UserNumber = int.Parse(GuessedNumber);
            // Console.Write($"Your guess was the # {GuessedNumber}");



            for (int i = 1; i <= NumOfGuess; i++)
            {
                if (GuessedNumber == SecretNumber)
                {
                    Console.WriteLine();
                    Console.WriteLine("Conga-Rats!! You Won!!");
                    return;
                }
                else
                {
                    if (SecretNumber > GuessedNumber)
                    {
                        Console.WriteLine("Guess Higher");
                    }
                    else
                    {
                        Console.WriteLine("Guess Lower");
                    }
                    Console.WriteLine();
                    Console.WriteLine(SecretNumber);
                    Console.WriteLine($"Guess Again. You have {NumOfGuess - i} left");
                    GuessedNumber = int.Parse(Console.ReadLine());

                }
            }

            if (GuessedNumber == SecretNumber)
            {
                Console.WriteLine("Conga-Rats!! You Won!!");
                return;
            }
            else
            {

                Console.WriteLine($"Out of Guesses.  The correct number was {SecretNumber}");
            }
        }
    }

}
