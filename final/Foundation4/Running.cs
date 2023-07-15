public class Running : Activity
{
    private double _distance;

    public Running(DateTime date, int minutes, double distance) : base(date, minutes)
    {
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (double)(_distance / _minutes) * 60;
    }

    public override double GetPace()
    {
        return (double)_minutes / _distance;
    }

    public override string GetSummary()
    {
        return $"{_date:d MMM yyyy} Running ({_minutes} min) - Distance: {GetDistance():0.00} km, Speed: {GetSpeed():0.00} kph, Pace: {GetPace():0.00} min per km";
    }
}