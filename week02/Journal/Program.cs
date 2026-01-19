using System;
using System.Security.Cryptography.X509Certificates;

class Program
{


    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Journal Project.");

        //For this assignment you will write a program to help people 
        //record the events of their day by supplying prompts
        // and then saving their responses along with 
        // the question and the date to a file. 

        Journal journal = new Journal();
        PromptGenerator promptGenerator = new PromptGenerator();
        

        bool running = true;

        while (running)
        {
            Console.WriteLine("");
            Console.WriteLine("1. Write new entry");
            Console.WriteLine("2. Display Journal");
            Console.WriteLine("3. Save Journal");
            Console.WriteLine("4. Load Journal");
            Console.WriteLine("5. exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                string prompt = promptGenerator.GetRandomPrompt();
                Console.WriteLine(prompt);
                Console.Write("> ");
                string response = Console.ReadLine();

                Entry entry = new Entry();
                entry._date = DateTime.Now.ToString("yyyy-MM-dd");
                entry._prompt = prompt;
                entry._response = response;

                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();
                journal.SaveFile(filename);
            }
            else if (choice == "4")
            {
                Console.Write("Filename: ");
                string filename = Console.ReadLine();
                journal.LoadFromFile(filename);
            }
            else
            {
                running = false;
            }
        }


    }
}