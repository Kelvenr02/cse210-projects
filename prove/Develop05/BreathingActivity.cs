using System;

public class BreathingActivity : Activity
{
    public BreathingActivity() : base("Breathing Activity", "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.") { }

    protected override void Execute()
    {
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("Breath in...");
            PauseWithCountdown(4);
            Console.Write("Now breath out...");
            PauseWithCountdown(4);
            Console.WriteLine();
        }
    }
}