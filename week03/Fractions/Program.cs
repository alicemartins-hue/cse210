using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Fractions Project.");

        Console.WriteLine("Lets do fraction!");

        Console.Write("Choose a number to be the top: ");
        int top = int.Parse(Console.ReadLine());

        Console.Write("Choose a number to be the bottom: ");
        int bottom = int.Parse(Console.ReadLine());

        Fraction fraction1 = new Fraction(top, bottom);
        string StringFraction = fraction1.GetFractionString();
        double decimalValue = fraction1.GetDecimalValue();

        Console.WriteLine($"{StringFraction}");
        Console.WriteLine($"{decimalValue}");

    }
}