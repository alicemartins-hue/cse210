
using System.Reflection.Metadata.Ecma335;

public class CyclingActivity : Activity
{
    private double _speed;

    public CyclingActivity(string date, int duration, double speed)
    : base(date, duration)
    {
        _speed = speed;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetDistance()
    {
        return _speed * GetDuration() / 60;
    }

    public override double GetPace()
    {
        return 60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{GetDate()} Cycling ({GetDuration()} min) - {GetDistance():F1} km, Speed {GetSpeed():F1}, Pace {GetPace():F1} min per km";
    }







}