public class Swimming : Activity
{
    private int _laps;

    public Swimming(DateTime date, int minutes, int laps) : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (double)_laps * 50 / 1000;
    }

    public override double GetSpeed()
    {
        return (GetDistance() / _minutes) * 60;
    }

    public override double GetPace()
    {
        return _minutes / GetDistance();
    }

    public override string GetSummary()
    {
        return $"{_date:d MMM yyyy} Swimming ({_minutes} min) - Distance:{GetDistance():0.00} km, Speed:{GetSpeed():0.00} kph, Pace:{GetPace():0.00} min per km";
    }
}