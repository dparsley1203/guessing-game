using System;

namespace guessing_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int SecretNumber = random.Next(1, 100);

            int NumOfGuess = 3;

            Console.WriteLine("Guess a number!");
            Console.Write("Enter Guess ");

            int GuessedNumber = int.Parse(Console.ReadLine());
            // int UserNumber = int.Parse(GuessedNumber);
            // Console.Write($"Your guess was the # {GuessedNumber}");



            for (int i = 1; i <= 3; i++)
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
                    Console.WriteLine($"Guess Again. You have {NumOfGuess--} left");
                    GuessedNumber = int.Parse(Console.ReadLine());

                }
            }

            Console.WriteLine($"The correct number was {SecretNumber}");
        }
    }

}
