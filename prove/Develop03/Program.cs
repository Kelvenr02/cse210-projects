using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Doctrine and Covenants", 19, 15, 19);
        string text = 
        @"Therefore I command you to repent—repent, lest I smite you by the rod of my mouth, and by my wrath, and by my anger, and your sufferings be sore—how sore you know not, how exquisite you know not, yea, how hard to bear you know not.
        For behold, I, God, have suffered these things for all, that they might not suffer if they would repent;
        But if they would not repent they must suffer even as I;
        Which suffering caused myself, even God, the greatest of all, to tremble because of pain, and to bleed at every pore, and to suffer both body and spirit—and would that I might not drink the bitter cup, and shrink—
        Nevertheless, glory be to the Father, and I partook and finished my preparations unto the children of men.
        ";
        Scripture scripture = new Scripture(reference, text);;
        Console.WriteLine(scripture.GetDisplayText());

        while (!scripture.IsCompletelyHidden())
        {
            Console.WriteLine("Press enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();
            if (input == "quit")
            {
                break;
            }
            scripture.HideRandomWords(2);
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
        }
    }
}