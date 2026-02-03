using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Homework Project.");

         Assignment test1 = new Assignment("Luis Carlos","European History");
        string summary = test1.GetSummary();
        Console.WriteLine(summary);

        Math test2 = new Math("Roberto Rodriguez", "Fractions", "7.3", "8-19");
        string summary2 = test2.GetSummary();
        string homework = test2.GetHomeworkList();
        Console.WriteLine();
        Console.WriteLine(summary2);
        Console.WriteLine(homework);

        Writing test3 = new Writing("Mary Waters", "European Geography", "The Causes of World War II");
        string summary3 = test3.GetSummary();
        string writing = test3.GetWritingInformation();
        Console.WriteLine();
        Console.WriteLine(summary3);
        Console.WriteLine(writing);

        
    }
}