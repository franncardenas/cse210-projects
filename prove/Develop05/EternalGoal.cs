public class EternalGoal : Goal
{
    public EternalGoal(string nameGoal, string description, int points) : base (nameGoal, description, points)
    {

    }
    public EternalGoal() : base()
    {
        
    }
    public override string ShowGoal()
    {
        return $"[ ] {_nameGoal} ({_description})";
    }
    public override int RecordEvent()
    {
        Console.WriteLine($"Congratulations! You have earned {_points} points!");
        return _points;
    }

    public override bool IsComplete()
    {
        return true;
    }

    public override string SaveToFile()
    {
        return $"EternalGoal:{_nameGoal},{_description},{_points}";
    }
    public override EternalGoal CreateGoal(string parameters)
    {
        string[] parts = parameters.Split(",");
        string nameGoal = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);


        EternalGoal eternalGoal = new EternalGoal(nameGoal, description, points);

        return eternalGoal;
    }
}