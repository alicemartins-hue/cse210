using System.IO;
public class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    public void DisplayStartingMessage()
    {
        Console.Clear();
        Console.Write($"Welcome to the {_name} Activity.");
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write(_description);
        Console.WriteLine("");
        Console.WriteLine("");
        Console.Write("How long, in seconds, would you like for your session? ");

        _duration = int.Parse(Console.ReadLine());

        Console.Clear();
        Console.WriteLine("Prepare to begin...");
        ShowSpinner(3);
    }

    public void DisplayEndingMessage()
    {
        Console.WriteLine();
        Console.WriteLine("Well done!!");
        ShowSpinner(3);

        Console.WriteLine($"You have completed another {_duration} seconds of the {_name} Activity.");
        ShowSpinner(3);

        SaveLog();
    }

    public void ShowSpinner(int second)
    {
        List<string> spinner = new List<string> { "|", "/", "-", "\\" };

        DateTime endTime = DateTime.Now.AddSeconds(second);

        int i = 0;
        while (DateTime.Now < endTime)
        {
            Console.Write(spinner[i]);
            Thread.Sleep(500);
            Console.Write("\b \b");

            i++;
            if (i >= spinner.Count)
            { 
                i = 0;
            }
        }
    }

    public void CountDown(int second)
    {
        for (int i = second; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public void SaveLog()
    {
        string log = $"{DateTime.Now} - {_name} for {_duration} seconds";
        File.AppendAllText("log.txt", log + Environment.NewLine);
    }

}