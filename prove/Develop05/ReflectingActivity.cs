using System;
using System.Collections.Generic;

public class ReflectingActivity : Activity
{
    private readonly List<string> _prompts = new()
    {
        "Think of a time when you achieved something you thought was impossible.",
        "Think of a time when you learned an important lesson from failure.",
        "Think of a time when you made someone else's day better.",
        "Think of a time when you showed kindness to a stranger.",
        "Think of a time when you overcame a significant fear.",
        "Think of a time when you worked as part of a team to achieve a goal.",
        "Think of a time when you solved a problem creatively.",
        "Think of a time when you stood by your values, even under pressure.",
        "Think of a time when you helped someone without expecting anything in return.",
        "Think of a time when you took responsibility for a mistake you made.",
        "Think of a time when you inspired someone else to take action.",
        "Think of a time when you learned something valuable from someone different from you.",
        "Think of a time when you made a difficult decision and it paid off.",
        "Think of a time when you apologized and made amends for a wrong you did.",
        "Think of a time when you went out of your way to support a friend."
    };

    private readonly List<string> _questions = new()
    {
        "What challenges did you face during this experience?",
        "Who or what inspired you during this experience?",
        "How did this experience change your perspective?",
        "What would you do differently if you could relive this experience?",
        "What skills or qualities did you develop through this experience?",
        "How did others react to your actions during this experience?",
        "What emotions did you feel throughout this experience?",
        "How has this experience influenced your goals or aspirations?",
        "What role did others play in helping you succeed in this experience?",
        "What surprised you the most about this experience?",
        "How did this experience push you out of your comfort zone?",
        "What advice would you give to someone going through a similar experience?",
        "What did this experience teach you about perseverance?",
        "How has this experience strengthened your relationships with others?",
        "What made this experience stand out from others in your life?"
    };

    public ReflectingActivity() : base("Reflecting Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in another aspects of your life.") { }

    protected override void Execute()
    {
        Random random = new Random();
        string prompt = _prompts[random.Next(_prompts.Count)];

        Console.WriteLine("Consider the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.WriteLine("When you have something in mind, press enter to continue.");
        Console.ReadLine();
        PauseWithSpinner(3);

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        foreach (string question in _questions)
        {
            Console.Write(question + " ");
            PauseWithSpinner(4);
            if (DateTime.Now >= endTime) break;
        }
    }
}