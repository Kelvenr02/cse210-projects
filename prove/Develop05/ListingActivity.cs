
using System;
using System.Collections.Generic;
using System.Threading;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>
    {
        "What are some blessings in your life that you are grateful for?",
        "Who has made a positive impact on your life recently?",
        "What goals have you accomplished this week?",
        "What are some talents or skills you have developed?",
        "When was a time you felt peace and comfort in your life?",
        "Who is someone you admire and why?",
        "What is something kind someone did for you this week?",
        "When was a moment you felt inspired to do something good?",
        "What is a lesson you have learned recently?",
        "Who has been a source of strength for you in challenging times?",
        "What is a memory that brings you joy?",
        "What is a challenge you have overcome recently?",
        "Who is someone you look up to for their example?",
        "What is something you have done recently that made you proud?",
        "When was a time you felt guided in a decision you made?"
    };


    public void Start()
    {
        Console.WriteLine("Welcome to the Listing Activity.");
        Console.WriteLine();
        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Console.WriteLine();
        SetDuration();
        Random random = new Random();
        string prompt = prompts[random.Next(prompts.Count)];
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine();
        Console.WriteLine($"--- {prompt} ---");
        Console.WriteLine();
        Console.Write("You may begin in: ");
        PauseWithCountdown(5);
        List<string> items = new List<string>();
        DateTime endTime = DateTime.Now.AddSeconds(_duration);
        while (DateTime.Now < endTime)
        {
            Console.Write("");
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) break;
            items.Add(input);
        }
        Console.WriteLine($"You listed {items.Count} items!");
        ShowCompletionMessage("Listing");
    }
}