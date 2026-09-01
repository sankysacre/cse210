using System;

class Program
{
    static void Main(string[] args)
    {
        // Outer loop allows playing the entire game multiple times (Stretch Challenge 2)
        string playAgain = "yes";

        while (playAgain.ToLower() == "yes")
        {
            // Step 3 Core Requirement: Generate random number between 1 and 100
            Random randomGenerator = new Random();
            int magicNumber = randomGenerator.Next(1, 101);

            int guess = -1;
            int guessCount = 0; // Stretch Challenge 1: Count user attempts

            // Inner loop continues prompting until guess matches magic number (Step 2 Core)
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                string guessInput = Console.ReadLine();
                guess = int.Parse(guessInput);
                guessCount++;

                // Step 1 Core Requirement: Compare guess against magic number
                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
            }

            // Display total attempt metrics (Stretch Challenge 1)
            Console.WriteLine($"It took you {guessCount} guesses!");

            // Prompt to restart game loop (Stretch Challenge 2)
            Console.Write("\nDo you want to play again (yes/no)? ");
            playAgain = Console.ReadLine();
            Console.WriteLine();
        }

        Console.WriteLine("Thanks for playing, Sanky!");
    }
}