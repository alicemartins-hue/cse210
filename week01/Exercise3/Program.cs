using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");


        Console.WriteLine("Welcome to the game!");
        Console.WriteLine("Discover the number");
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 20);

        int track = 0;

        Console.Write("What is your guess? ");
        int yourGuess = int.Parse(Console.ReadLine());
        track++;


        while (yourGuess != magicNumber)
        {
            if (yourGuess < magicNumber)
            {
                Console.WriteLine("Higher");
            }
            else if (yourGuess > magicNumber)
            {
                Console.WriteLine("Lower");
            }

            Console.Write("What is your guess? ");
            yourGuess = int.Parse(Console.ReadLine());
            track++;


        }

        Console.WriteLine("You guessed it!");
        Console.WriteLine($"The guest guessed {track} times.");

        Console.Write("Did you want to play again? (y/yes) ");
        string playAgain = Console.ReadLine();

        while (playAgain.ToLower() == "yes" || playAgain.ToLower() == "y")
        {
            Console.Write("What is your guess? ");
            yourGuess = int.Parse(Console.ReadLine());
            track++;

            Console.WriteLine("You guessed it!");
            Console.WriteLine($"The guest guessed {track} times.");

            Console.Write("Did you want to play again? (y/yes) ");
            playAgain = Console.ReadLine();
        }

        Console.WriteLine("This was a good game!");

    }
}