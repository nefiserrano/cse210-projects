using System;

public class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>();

    public ListingActivity()
    {
        _name = "Listing Activity";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
        _duration = 50;

        _count = 0;
        _prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();

        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.WriteLine("List as many responses you can to the following prompt:");
        string prompt = GetRandomPrompt();
        Console.WriteLine($"--- {prompt} ---");

        Console.Write("You may begin in: ");
        ShowCountDown(5);
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        List<string> list = new List<string>();

        while (DateTime.Now < endTime)
        {
            Console.Write("> ");
            list.AddRange(GetListFromUser());
        }

        _count = list.Count();
        Console.WriteLine($"You listed {_count} items!");

        Console.WriteLine("");
        DisplayEndingMessage();
    }

    public string GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        string randomPrompt = _prompts[index];
        return randomPrompt;
    }

    public List<string> GetListFromUser()
    {
        List<string> answers = new List<string>();
        answers.Add(Console.ReadLine());
        return answers;
    }
}