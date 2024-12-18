abstract class Goal
{
    private string _goalType;
    private string _name;
    private string _description;
    private int _points;

    public virtual void CreateGoal(string name, string description, int points, bool complete = false, int completionNumber = 0, int currentNumber = 0, int bonusPoints = 0)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    public abstract void SetGoal();
    public abstract string SaveGoal();

    public virtual int RecordProgress()
    {
        return _points;
    }

    public virtual void DisplayProgress()
    {
        Console.WriteLine($"[ ] {_name} ({_description})");
    }

    public void SetGoalType(string goalType) => _goalType = goalType;
    public string GetGoalType() => _goalType;

    public void SetName(string name) => _name = name;
    public string GetName() => _name;

    public void SetDescription(string description) => _description = description;
    public string GetDescription() => _description;

    public void SetPoints(int points) => _points = points;
    public int GetPoints() => _points;
}