//My program exceeds the requirements because it selects a random word to hide it from only those
//words that are not already hidden, instead of selecting a word that is already hidden.

using System;

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Proverbs", 3, 5, 6);
        string scriptureText = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        Scripture scripture = new Scripture(reference, scriptureText);

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            Console.WriteLine("\nPress enter to continue or type 'quit' to finish:");
            string answer = Console.ReadLine();

            if (answer == "quit" || scripture.IsCompletelyHidden())
            {
                break;
            }
            else
            {
                scripture.HideRandomWords(3);
            }
        }
    }
}