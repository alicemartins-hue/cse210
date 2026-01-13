using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise5 Project.");

        DisplayWelcome();

        string userName = PromptUserName();
        int favoriteNumber = PromptUserNumber();

        int square = SquareNumber(favoriteNumber);

        DisplayResult(userName, square);
        
        static void DisplayWelcome()
        {
            Console.WriteLine($"Welcome to the program!");
        }

        static string PromptUserName()
        {
            Console.Write("Enter your name: ");
            string username = Console.ReadLine();
            return username;
        }

        static int PromptUserNumber()
        {
            Console.Write("Please enter your favorite number: ");
            int number = int.Parse(Console.ReadLine());
            return number;
        }

        static int SquareNumber(int number)
        {
            int square = number * number;
            return square;
        }   

        static void DisplayResult(string username, int square)
        {
            Console.WriteLine($"{username}, the square of your favorite number is {square}");

        }



    }
}