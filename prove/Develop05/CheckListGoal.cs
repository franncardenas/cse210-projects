public class ChecklistGoal : Goal
{
    private int _times;
    private int _attempts;
    private int _bonus;

    public ChecklistGoal() : base()
    {

    }
    public ChecklistGoal(string nameGoal, string description, int points, int times, int bonus) : base (nameGoal, description, points)
    {
        _times = times;
        _bonus = bonus;
        _attempts = times - times;
    }

    public ChecklistGoal(string nameGoal, string description, int points, int bonus, int times, int attempts) : base (nameGoal, description, points)
    {
        _times = times;
        _bonus = bonus;
        _attempts = attempts;
    }

    public override string ShowGoal()
    {
        if (IsComplete())
        {
            return $"[X] {_nameGoal} ({_description}) -- Currently completed: {_attempts}/{_times}";
        }
        else 
        {
            return $"[ ] {_nameGoal} ({_description}) -- Currently completed: {_attempts}/{_times}";
        }
    }

    public override int RecordEvent()
    {   
        if (IsComplete())
        {
            Console.WriteLine("You have completed this goal");
            return 0;
        }
        else if (_attempts < _times)
        {
            _attempts += 1;
            if (_attempts == _times)
            {
                _ok = true;
                Console.WriteLine($"Congratulations! You have won the last {_points} points!" +
                    $"\nYou have also earned {_bonus}bonus points for finishing the goal.");
                return _points + _bonus;
            }
            else 
            {
                Console.WriteLine($"Congratulations! You have earned {_points} points!");
                return _points;
            } 
        }
        else 
        {
            Console.WriteLine("You have completed this goal");
            return 0;
        }
    }

    public override bool IsComplete()
    {
        if (_times == _attempts)
        {
            _ok = true;        
            return _ok;
        } 
        else 
        {
            _ok = false;
            return _ok;
        }
            
    }
    public override string SaveToFile()
    {
        return $"ChecklistGoal:{_nameGoal},{_description},{_points},{_bonus},{_times},{_attempts}";
    }
    public override ChecklistGoal CreateGoal(string parameters)
    {
        string[] parts = parameters.Split(",");
        string nameGoal = parts[0];
        string description = parts[1];
        int points = int.Parse(parts[2]);
        int bonus = int.Parse(parts[3]);
        int times = int.Parse(parts[4]);
        int attempts = int.Parse(parts[5]);

        ChecklistGoal checklistGoal = new ChecklistGoal(nameGoal, description, points, bonus, times, attempts);

        return checklistGoal;
    }
    
}