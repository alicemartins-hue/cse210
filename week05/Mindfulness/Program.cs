using System;
using System.Globalization;
using System.IO;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {


        string choice = "";
        while (choice != "6")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start Breathing Activity");
            Console.WriteLine("2. Start Reflecting Activity");
            Console.WriteLine("3. Start Listing Activity");
            Console.WriteLine("4. View Activity Log");
            Console.WriteLine("5. Clear Activity Log");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                BreathingActivity activity = new BreathingActivity();
                activity.Run();
            }
            else if (choice == "2")
            {
                ReflectingActivity activity = new ReflectingActivity();
                activity.Run();
            }
            else if (choice == "3")
            {
                ListingActivity activity = new ListingActivity();
                activity.Run();
            }
            else if (choice == "4")
            {
                ViewLog();
            }
            else if (choice == "5")
            {
                ClearLog();
            }
            else
            {
                Console.WriteLine("Invalid choice. Press Enter to continue.");
                Console.ReadLine();
            }

        }


    }

    static void ViewLog()
    {
        Console.Clear();

        if (File.Exists("log.txt"))
        {
            string[] lines = File.ReadAllLines("log.txt");

            Console.WriteLine("Activity Log:");
            Console.WriteLine("----------------------");

            foreach (string line in lines)
            {
                Console.WriteLine(line);
            }
        }
        else
        {
            Console.WriteLine("No log file found.");
        }

        Console.WriteLine("\nPress Enter to return to menu.");
        Console.ReadLine();
    }

    static void ClearLog()
    {
        Console.Clear();

        if (File.Exists("log.txt"))
        {
            Console.WriteLine("Are you sure you want to delete the activity? ");
            string confirm = Console.ReadLine().ToLower();

            if (confirm == "y")
            {
                File.WriteAllText("log.txt", "");
                Console.WriteLine("Log cleared sucessfully.");

            }
            else
            {
                Console.WriteLine("Log was not deleted.");
            }

        }
        else
        {
            Console.WriteLine("No Log file found.");
        }

        Console.WriteLine("\nPress Enter to return to menu.");
        Console.ReadLine();
    }

}