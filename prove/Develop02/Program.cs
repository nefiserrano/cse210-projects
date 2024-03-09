// The program stores the time of each entry and keeps track of how many times the user
// has added new entries to the journal and displays this information along the rest
// of information.

using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the journal program!");

        PromptGenerator promptGenerator = new PromptGenerator();

        promptGenerator._prompts.Add("How did I feel the Holy Ghost today?");
        promptGenerator._prompts.Add("What did I learn today?");
        promptGenerator._prompts.Add("What could I have done better today?");
        promptGenerator._prompts.Add("What was the funniest thing I did today?");
        promptGenerator._prompts.Add("What challenge did I face today?");

        Journal journal = new Journal();

        string choice = "";
        while (choice != "5")
        {
            Console.WriteLine("Please select one of the following choices:");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do?");
            choice = Console.ReadLine();
    
            if (choice == "1")
            {
                Entry entry = new Entry();
                entry._promptText = promptGenerator.GetRandomPrompt();
                entry._entryText = Console.ReadLine();
                journal.AddEntry(entry);
            }
            else if (choice == "2")
            {
                journal.DisplayAll();
            }
            else if (choice == "3")
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal.LoadFromFile(file);
            }
            else if (choice == "4")
            {
                Console.WriteLine("What is the filename?");
                string file = Console.ReadLine();
                journal.SaveToFile(file);
            }
        }
    }
}