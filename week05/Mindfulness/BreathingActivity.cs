
public class BreatingActivity : Activity
{
    public BreatingActivity()
    : base("Breathing",
    "This activity will help you relax by guiding you through breathin in and out slowlt. Clear your mind and focus on your breathing.")
    {
    }
    
    public void Run()
    {
        DisplayStartingMessage();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathig in... ");
            CountDown(4);
            Console.WriteLine();

            Console.Write("Breathe out... ");
            CountDown(4);
            Console.WriteLine();
        }

        DisplayEndingMessage();
    }
}