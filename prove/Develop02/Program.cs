using System;

class Program
{
    static void Main(string[] args)
    {
        PromptGenerator promptGenerator = new PromptGenerator();
        Journal journal = new Journal();
        while (true)
        {
            Menu();
            Console.Write("What would you like to do? ");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    string prompt = promptGenerator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("Your response: ");
                    string response = Console.ReadLine();
                    string date = DateTime.Now.ToShortDateString();
                    Entry newEntry = new Entry(date, prompt, response);
                    journal.AddEntry(newEntry);
                    break;
                case "2":
                    journal.DisplayAll();
                    break;
                case "3":
                    Console.Write("What is the filename? ");
                    string file2 = Console.ReadLine();
                    journal.LoadFromFile(file2);
                    break;
                case "4":
                    Console.Write("What is the filename? ");
                    string file1 = Console.ReadLine();
                    journal.SaveToFile(file1);
                    break;
                case "5":
                    return;
                default:
                    Console.WriteLine("Invalid option! Entry a correct value.");
                    break;
            }
        }
    }
    private static void Menu()
    {
        Console.WriteLine("Welcome to the Journal Program!");
        Console.WriteLine("Please select one of the following choices:");
        Console.WriteLine("1. Write");
        Console.WriteLine("2. Display");
        Console.WriteLine("3. Load");
        Console.WriteLine("4. Save");
        Console.WriteLine("5. Quit");
    }
}