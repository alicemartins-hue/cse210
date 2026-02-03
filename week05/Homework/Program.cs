using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

        Assignment test1 = new Assignment("Luis Carlos", "European History");
        string summary = test1.GetSummary();
        Console.WriteLine(summary);
    }
}