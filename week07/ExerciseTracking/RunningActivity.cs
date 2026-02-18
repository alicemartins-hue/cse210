
public class RunningActivity : Activity
{
    private double _distance;

    public RunningActivity(string date, int duration, double distance)
    : base(date, duration)
    {
        _distance = distance;
    }


    public override double GetSpeed()
    {
        return _distance / GetDuration() * 60;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetPace()
    {
        return GetDuration() / _distance;
    }


    public override string GetSummary()
    {
        return $"{GetDate()} Running ({GetDuration()} min) - {GetDistance():F1} km, Speed {GetSpeed():F1}, Pace {GetPace():F1} min per km";
    }



}