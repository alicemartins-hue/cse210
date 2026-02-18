using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity("03 Nov 2022", 30, 4.8));
        activities.Add(new CyclingActivity("03 Nov 2022", 30, 20.0));
        activities.Add(new SwimmingActivity("03 Nov 2022", 30, 40));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }



    }
}