public class SimplyGoal : Goal
{
    public SimplyGoal(string nameGoal, string description, int points) : base (nameGoal, description, points)
    {

    }
    public SimplyGoal(string nameGoal, string description, int points, bool ok) : base (nameGoal,description, points)
    {
        _ok = ok;
    }
    public SimplyGoal() : base()
    {
        
    }
    public override int RecordEvent()
    {
        if (IsComplete())
        {
            return 0;
        }
        else 
            _ok = true;
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
            return _points;
    }
    public override string ShowGoal()
    {
        if (IsComplete())
        {
            return $"[X] {_nameGoal} ({_description})";
        }
        else 
            return $"[ ] {_nameGoal} ({_description})";  
    }
    public override bool IsComplete()
    {
        return _ok;
    }

    public override string SaveToFile()
    {
        if (IsComplete())
        {
            return $"SimpleGoal:{_nameGoal},{_description},{_points},True";
        }
        else 
        {
            return $"SimpleGoal:{_nameGoal},{_description},{_points},False";
        }
    }
    public override SimplyGoal CreateGoal(string parameters)
    {
        string[] parts = parameters.Split(",");
        string nameGoal = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        bool ok = bool.Parse(parts[3]);

        SimplyGoal simpleGoal = new SimplyGoal(nameGoal, description, points, ok);

        return simpleGoal;
    }
}