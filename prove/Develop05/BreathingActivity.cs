using System;
using System.Threading;

public class BreathingActivity : Activity
{
    public void Start()
    {
        Console.WriteLine("Welcome to the Breathing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Console.WriteLine();
        SetDuration();

        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            PauseWithCountdown(4);
            Console.Write("Now breath out...");
            PauseWithCountdown(4);
            Console.WriteLine();
        }

        ShowCompletionMessage("Breathing");
    }
}