public class Cycling : Activity
{
    private double _speed;

    public Cycling(DateTime date, int minutes, double speed) : base (date, minutes)
    {
        _speed = speed;
    }

    public override double GetDistance()
    {
        return (_speed * _minutes) / (double)60;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        return (double)60 / _speed;
    }

    public override string GetSummary()
    {
        return $"{_date:d MMM yyyy} Cycling ({_minutes} min) - Distance:{GetDistance():0.00} km, Speed:{GetSpeed():0.00} kph, Pace:{GetPace():0.00} min per km";
    }
}