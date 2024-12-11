using System;
using System.Collections.Generic;
using System.Threading;

public class Activity
{
    protected int _duration;

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
        Console.Clear();
        Console.WriteLine("Get ready...");
        PauseWithSpinner(3);
    }
    protected void ShowCompletionMessage(string activityName)
    {
        Console.WriteLine("Well done!");
        PauseWithSpinner(2);
        Console.WriteLine($"You have completed another {_duration} seconds of the {activityName} Activity.");
        PauseWithSpinner(2);
    }
    protected void PauseWithSpinner(int seconds)
    {
        char[] spinner = { '|', '/', '-', '\\' };
        int spinnerIndex = 0;
        for (int i = 0; i < seconds * 4; i++)
        {
            Console.Write(spinner[spinnerIndex]);
            Thread.Sleep(500);
            Console.Write("\b \b");
            spinnerIndex = (spinnerIndex + 1) % spinner.Length;
        }
        Console.WriteLine();
    }
    protected void PauseWithCountdown(int seconds)
    {
        for (int i = seconds; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
        Console.WriteLine();
    }
}