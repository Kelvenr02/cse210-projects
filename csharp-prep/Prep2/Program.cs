using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueInText = Console.ReadLine();

        float gradePercentage = int.Parse(valueInText);

        string letter;
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade: {letter}");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulation! You passed the class.");
        }
        else
        {
            Console.WriteLine("You did not pass the class. Keep working, you will get it!");
        }
    }
}