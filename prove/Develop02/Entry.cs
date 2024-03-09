using System;

public class Entry
{
    DateTime _theCurrentTime = DateTime.Now;
    public string _date;
    public string _time;

    public string _promptText;
    public string _entryText;

    static int _entryCount= 0;
    public int _entryNumber;

    public Entry()
    {
        _date = _theCurrentTime.ToShortDateString();
        _time = _theCurrentTime.ToShortTimeString();
        _entryNumber = ++_entryCount;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Time: {_time} - Prompt: {_promptText}");
        Console.WriteLine($"Entry: {_entryNumber} - {_entryText}");
        Console.WriteLine("");
    }
}