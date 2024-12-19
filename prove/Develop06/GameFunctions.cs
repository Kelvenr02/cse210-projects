class GameFunctions
{
    private int _totalScore = 0;
    private List<Goal> _loadedGoals = new List<Goal>();
    private int _level = 1;
    private int _levelRequirement = 100;

    public void Save(string fileName, List<Goal> goals)
    {
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_totalScore);
            outputFile.WriteLine($"Level,{_level},{_levelRequirement}");

            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.SaveGoal());
            }
        }
    }

    public void Load(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            string goalType = parts[0];
            
            switch (goalType)
            {
                case "SimpleGoal":
                    LoadSimpleGoal(parts);
                    break;
                case "EternalGoal":
                    LoadEternalGoal(parts);
                    break;
                case "ChecklistGoal":
                    LoadChecklistGoal(parts);
                    break;
                case "Level":
                    LoadLevel(parts);
                    break;
                default:
                    if (int.TryParse(parts[0], out int score))
                    {
                        _totalScore = score;
                    }
                    break;
            }
        }
    }

    private void LoadSimpleGoal(string[] parts)
    {
        var goal = new SimpleGoal();
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        bool complete = bool.Parse(parts[4]);

        goal.CreateGoal(name, description, points, complete);
        _loadedGoals.Add(goal);
    }

    private void LoadEternalGoal(string[] parts)
    {
        var goal = new EternalGoal();
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);

        goal.CreateGoal(name, description, points);
        _loadedGoals.Add(goal);
    }

    private void LoadChecklistGoal(string[] parts)
    {
        var goal = new ChecklistGoal();
        string name = parts[1];
        string description = parts[2];
        int points = int.Parse(parts[3]);
        int completionNumber = int.Parse(parts[4]);
        int currentNumber = int.Parse(parts[5]);
        int bonusPoints = int.Parse(parts[6]);

        goal.CreateGoal(name, description, points, false, completionNumber, currentNumber, bonusPoints);
        _loadedGoals.Add(goal);
    }

    private void LoadLevel(string[] parts)
    {
        _level = int.Parse(parts[1]);
        _levelRequirement = int.Parse(parts[2]);
    }

    public void AddPoints(int points)
    {
        _totalScore += points;
    }

    public void DisplayScore()
    {
        Console.WriteLine();
        Console.WriteLine($"You have {_totalScore} points.");
        int scoreLeft = _totalScore > 0 ? LevelUp() : _levelRequirement;
        Console.WriteLine($"Your current level is {_level}. Only {scoreLeft} points left to reach level {_level + 1}");
        Console.WriteLine();
    }

    private int LevelUp()
    {
        if (_totalScore >= _levelRequirement)
        {
            _level++;
            _levelRequirement += _level * 150;
        }
        return _levelRequirement - (_totalScore % _levelRequirement);
    }

    public List<Goal> GetLoadedGoals()
    {
        return _loadedGoals;
    }
}