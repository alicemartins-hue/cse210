
public class BreathingActivity : Activity
{
    public BreathingActivity()
    : base("Breathing",
    "This activity will help you relax by guiding you through breathing in and out slowly.\n Clear your mind and focus on your breathing.")
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
            CountDown(6);
            Console.WriteLine();

            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }
}