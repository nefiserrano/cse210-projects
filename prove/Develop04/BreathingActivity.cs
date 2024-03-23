using System;

public class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing Activity";
        _description = "This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.";
        _duration = 50;
    }

    public void Run()
    {
        DisplayStartingMessage();
        Console.Clear();
        
        Console.WriteLine("Get ready...");
        ShowSpinner(5);
        Console.WriteLine("");

        Console.Write("How many seconds do you want to breath in? ");
        int breathIn = int.Parse(Console.ReadLine());
        Console.Write("How many seconds do you want to breath out? ");
        int breathOut = int.Parse(Console.ReadLine());
        Console.WriteLine("");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            Console.Write("Breathe in...");
            ShowCountDown(breathIn);

            Console.WriteLine("");
            Console.Write("Now breathe out...");
            ShowCountDown(breathOut);

            Console.WriteLine("");
            Console.WriteLine("");
        }

        DisplayEndingMessage();
    }
}