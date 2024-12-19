class SimpleGoal : Goal
{
    private bool _complete;

    public override void CreateGoal(string name, string description, int points, bool complete = false, int completionNumber = 0, int currentNumber = 0, int bonusPoints = 0)
    {
        SetGoalType("SimpleGoal");
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        _complete = complete;
    }

    public override void SetGoal()
    {
        SetGoalType("SimpleGoal");
        Console.Write("What is the name of your goal? ");
        SetName(Console.ReadLine());

        Console.Write("What is a short description of it? ");
        SetDescription(Console.ReadLine());

        Console.Write("What is the amount of points associated with this goal? ");
        if (int.TryParse(Console.ReadLine(), out int points))
        {
            SetPoints(points);
        }
        else
        {
            Console.WriteLine("Invalid points input. Setting points to 0.");
            SetPoints(0);
        }
    }

    public override int RecordProgress()
    {
        if (!_complete)
        {
            _complete = true;
            return GetPoints();
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }

    public override void DisplayProgress()
    {
        string status = _complete ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GetName()} ({GetDescription()})");
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()},{GetName()},{GetDescription()},{GetPoints()},{_complete}";
    }

    public void SetComplete(bool complete) => _complete = complete;
    public bool GetComplete() => _complete;
}