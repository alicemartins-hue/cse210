public class SwimmingActivity : Activity
{
    private int _numberOfLabs = 50;

    public SwimmingActivity(string date, int duration, int numberOfLabs)
    : base(date, duration)
    {
        _numberOfLabs = numberOfLabs;
    }

    public int GetNumberOfLabs()
    {
        return _numberOfLabs;
    }

    public override double GetSpeed()
    {
        return GetDistance() / GetDuration() * 60;
    }

    public override double GetDistance()
    {
        return _numberOfLabs * 50 / 1000.0;
    }

    public override double GetPace()
    {
        return GetDuration() / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Swimming ({GetDuration()} min) - {GetDistance():F1} km, Speed {GetSpeed():F1}, Pace {GetPace():F1} min per km";
    }
}