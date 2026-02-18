using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the ExerciseTracking Project.");

        List<Activity> activities = new List<Activity>();

        activities.Add(new RunningActivity("03 Nov 2022", 30, 4.8));

        foreach (Activity activity in activities)
        {
            Console.WriteLine(activity.GetSummary());
        }



    }
}