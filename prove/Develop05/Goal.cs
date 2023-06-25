public abstract class Goal
{
    protected string _nameGoal;
    protected string _description;
    protected int _points;
    protected bool _ok;

    public Goal()
    {
        
    }
    public Goal(string nameGoal, string description, int points)
    {
        _nameGoal = nameGoal;
        _description = description;
        _points = points;
        _ok = false;
    }
    public string  GetName()
    {
        return _nameGoal;
    }
    public abstract string ShowGoal();
    public abstract int RecordEvent();
    public abstract bool IsComplete();
    public abstract string SaveToFile();
    public abstract Goal CreateGoal(string parameters);

}