using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        GameFunctions game = new GameFunctions();
        List<Goal> goalList = new List<Goal>();
        Dictionary<string, Goal> goalTypes = InitializeGoalTypes();

        int userChoice;
        string userEntry;

        do
        {
            game.DisplayScore();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Create New Goal");
            Console.WriteLine("  2. List Goals");
            Console.WriteLine("  3. Save Goals");
            Console.WriteLine("  4. Load Goals");
            Console.WriteLine("  5. Record Event");
            Console.WriteLine("  6. Quit");
            Console.Write("Select a choice from the menu: ");
            userEntry = Console.ReadLine();
            userChoice = int.Parse(userEntry);

            switch (userChoice)
            {
                case 1:
                    CreateNewGoal(goalTypes, goalList);
                    break;

                case 2:
                    ListGoals(goalList);
                    break;

                case 3:
                    SaveGoals(game, goalList);
                    break;

                case 4:
                    LoadGoals(game, goalList);
                    break;

                case 5:
                    RecordEvent(game, goalList);
                    break;

                case 6:
                    Console.WriteLine("Farewell until next time!");
                    break;

                default:
                    Console.WriteLine("I'm sorry, but that wasn't a valid entry. Please try again.");
                    break;
            }

        } while (userChoice != 6);
    }

    static Dictionary<string, Goal> InitializeGoalTypes()
    {
        return new Dictionary<string, Goal>
        {
            { "1", new SimpleGoal() },
            { "2", new EternalGoal() },
            { "3", new ChecklistGoal() }
        };
    }

    static void CreateNewGoal(Dictionary<string, Goal> goalTypes, List<Goal> goalList)
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("  1. Simple Goal");
        Console.WriteLine("  2. Eternal Goal");
        Console.WriteLine("  3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        
        string userEntry = Console.ReadLine();
        if (goalTypes.ContainsKey(userEntry))
        {
            Goal newGoal = goalTypes[userEntry];
            newGoal.SetGoal();
            goalList.Add(newGoal);
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid goal type.");
        }
    }

    static void ListGoals(List<Goal> goalList)
    {
        int counter = 1;
        Console.WriteLine("The goals are:");
        foreach (Goal goal in goalList)
        {
            Console.Write($"{counter}. ");
            goal.DisplayProgress();
            counter++;
        }
    }

    static void SaveGoals(GameFunctions game, List<Goal> goalList)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine() + ".txt";
        game.Save(fileName, goalList);
    }

    static void LoadGoals(GameFunctions game, List<Goal> goalList)
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine() + ".txt";
        game.Load(fileName);
        goalList.Clear();
        goalList.AddRange(game.GetLoadedGoals());
    }

    static void RecordEvent(GameFunctions game, List<Goal> goalList)
    {
        int counter = 1;
        foreach (Goal goal in goalList)
        {
            Console.WriteLine($"{counter}. {goal.GetName()}");
            counter++;
        }

        Console.Write("Which goal did you accomplish? ");
        string userEntry = Console.ReadLine();
        if (int.TryParse(userEntry, out int userChoice) && userChoice >= 1 && userChoice <= goalList.Count)
        {
            game.AddPoints(goalList[userChoice - 1].RecordProgress());
        }
        else
        {
            Console.WriteLine("Invalid choice. Please select a valid goal.");
        }
    }
}