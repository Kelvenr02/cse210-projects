class EternalGoal : Goal
{
    public override void CreateGoal(string name, string description, int points, bool complete = false, int completionNumber = 0, int currentNumber = 0, int bonusPoints = 0)
    {
        SetGoalType("EternalGoal");
        SetName(name);
        SetDescription(description);
        SetPoints(points);
    }

    public override void SetGoal()
    {
        SetGoalType("EternalGoal");
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

    public override string SaveGoal()
    {
        return $"{GetGoalType()},{GetName()},{GetDescription()},{GetPoints()}";
    }
}