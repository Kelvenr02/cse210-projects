using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        while (guess != magicNumber)
        {
            Console.Write("What is your guess? ");
            string valueInText2 = Console.ReadLine();
            guess = int.Parse(valueInText2);
            
            if (magicNumber > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
        }
        Console.WriteLine("You guessed it!");
    }
}