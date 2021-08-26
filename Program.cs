using System;
using System.Collections.Generic;


namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose a Difficulty 1 - Easy, 2 - Medium, 3 - Hard, 4 - Cheater");
            int difficulty = int.Parse(Console.ReadLine());

            var guesses = new List<int>
            {
                7, 5, 3, int.MaxValue
            };

            Random random = new Random();
            int SecretNumber = random.Next(1, 100);

            int NumOfGuess = guesses[difficulty - 1];

            Console.WriteLine("Guess a number!");
            Console.Write("Enter Guess ");

            int GuessedNumber = int.Parse(Console.ReadLine());
            // int UserNumber = int.Parse(GuessedNumber);
            // Console.Write($"Your guess was the # {GuessedNumber}");



            // will show a wrong answer if you guess correctly on last attempt
            for (int i = 1; i <= NumOfGuess; i++)
            {
                if (NumOfGuess > 10)
                {
                    Console.WriteLine("You have Unlimited Guesses");
                }
                else
                {
                    System.Console.WriteLine($"Guess Again. You have {NumOfGuess - i} left");
                }
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
                    // Console.WriteLine($"Guess Again. You have {NumOfGuess - i} left");
                    GuessedNumber = int.Parse(Console.ReadLine());

                }
            }
            //code would not say you won if you guessed the number on the last attempt.  This code allows it to display the winning prompt.
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
