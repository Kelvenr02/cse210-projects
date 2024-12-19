class ChecklistGoal : Goal
{
    private int _completionNumber;
    private int _currentNumber = 0;
    private int _bonusPoints;

    public override void CreateGoal(string name, string description, int points, bool complete = false, int completionNumber = 0, int currentNumber = 0, int bonusPoints = 0)
    {
        SetGoalType("ChecklistGoal");
        SetName(name);
        SetDescription(description);
        SetPoints(points);
        _completionNumber = completionNumber;
        _currentNumber = currentNumber;
        _bonusPoints = bonusPoints;
    }

    public override void SetGoal()
    {
        SetGoalType("ChecklistGoal");
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

        Console.Write("How many times does this goal need to be accomplished for a bonus? ");
        if (int.TryParse(Console.ReadLine(), out int completionNumber) && completionNumber > 0)
        {
            _completionNumber = completionNumber;
        }
        else
        {
            _completionNumber = 1;
        }

        Console.Write("What is the bonus for accomplishing it that many times? ");
        if (int.TryParse(Console.ReadLine(), out int bonusPoints))
        {
            _bonusPoints = bonusPoints;
        }
        else
        {
            _bonusPoints = 0;
        }
    }

    public override int RecordProgress()
    {
        if (_currentNumber < _completionNumber)
        {
            _currentNumber++;
            return _currentNumber == _completionNumber ? (GetPoints() + _bonusPoints) : GetPoints();
        }
        else
        {
            Console.WriteLine("This goal has already been completed.");
            return 0;
        }
    }

    public override void DisplayProgress()
    {
        string status = _currentNumber == _completionNumber ? "[X]" : "[ ]";
        Console.WriteLine($"{status} {GetName()} ({GetDescription()}) --- Currently Completed: {_currentNumber}/{_completionNumber}");
    }

    public override string SaveGoal()
    {
        return $"{GetGoalType()},{GetName()},{GetDescription()},{GetPoints()},{_completionNumber},{_currentNumber},{_bonusPoints}";
    }

    public void SetCompletionNumber(int number) => _completionNumber = number;
    public int GetCompletionNumber() => _completionNumber;

    public void SetCurrentNumber(int number) => _currentNumber = number;
    public int GetCurrentNumber() => _currentNumber;

    public void SetBonusPoints(int points) => _bonusPoints = points;
    public int GetBonusPoints() => _bonusPoints;
}