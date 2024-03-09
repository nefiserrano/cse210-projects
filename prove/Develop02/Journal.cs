using System;
using System.IO; 

public class Journal
{
    public List<Entry> _entries = new List<Entry>();

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry b in _entries)
        {
            b.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (StreamWriter outputFile = new StreamWriter(file))
        {
            foreach (Entry b in _entries)
            {
                outputFile.WriteLine($"{b._date}-{b._time}-{b._promptText}-{b._entryText}-{b._entryNumber}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries.Clear();
        string[] lines = System.IO.File.ReadAllLines(file);
        
        foreach (string line in lines)
        {
            string[] parts = line.Split("-");

            Entry loadedEntry = new Entry
            {
                _date = parts[0],
                _time = parts[1],
                _promptText = parts[2],
                _entryText = parts[3],
                _entryNumber = int.Parse(parts[4]),
            };

            _entries.Add(loadedEntry);
        }
    }
}