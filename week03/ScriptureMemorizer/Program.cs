using System;
using System.Text.Json;

class Program
{
    static void Main(string[] args)
    {

        //scripture and reference
        //prompt to continue

        string json = File.ReadAllText("verses.json");

        List<VerseData> verses =
            JsonSerializer.Deserialize<List<VerseData>>(json);

        Random random = new Random();
        VerseData v = verses[random.Next(verses.Count)];

        Reference reference1 = new Reference(v.book, v.chapter, v.verse);
        Scripture scripture = new Scripture(reference1, v.text);

        Console.Clear();
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Please enter to continue or type 'quit' to finish");
            Console.Write("... ");
            string answer = Console.ReadLine();

            if (answer == "quit")
            {
                break;
            }

            scripture.HideRandomWords(3);

            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }

    }
}