using System;
using System.Formats.Asn1;
using System.IO; 

public class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private int _level;
    private string _levelName;

    public GoalManager()
    {
        _goals = new List<Goal>();
        _score = 0;
        _level = 1;
        _levelName = "Begginer";
    }

    public void Start()
    {
        string choice = "";
        while (choice != "6")
        {
            Console.WriteLine("");
            DisplayPlayerInfo();
            DisplayLevelInfo();
            Console.WriteLine("");
            Console.WriteLine("Menu Options");
            Console.WriteLine("1. Create New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Select a choice from the menu: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                CreateGoal();
            }
            else if (choice == "2")
            {
                ListGoalDetails();
            }
            else if (choice == "3")
            {
                SaveGoals();
            }
            else if (choice == "4")
            {
                LoadGoals();
            }
            else if (choice == "5")
            {
                ListGoalNames();
                RecordEvent();
            }
        }
    }  

    public void DisplayLevelInfo()
    {
        if (_score >= 200 && _score < 400)
        {
            _level = 2;
            _levelName = "Apprentice";
        }
        else if (_score >= 400 && _score < 600)
        {
            _level = 3;
            _levelName = "Sage";
        }
        else if (_score >= 600 && _score < 800)
        {
            _level = 4;
            _levelName = "Expert";
        }
        else if (_score >= 800 && _score < 1000)
        {
            _level = 5;
            _levelName = "Master";
        }
        else if (_score >= 1000)
        {
            _level = 6;
            _levelName = "Legendary";
        }

        Console.WriteLine($"Level {_level}: {_levelName}");
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }

    public void ListGoalNames()
    {
        Console.WriteLine("The goals are:");

        int number = 1;

        foreach(Goal goal in _goals)
        {
            string text = goal.GetName();
            Console.Write($"{number}. ");
            Console.WriteLine(text);
            number++;
        }
    }

    public void ListGoalDetails()
    {
        Console.WriteLine("The goals are:");

        int number = 1;

        foreach(Goal goal in _goals)
        {
            string text = goal.GetDetailsString();
            Console.Write($"{number}. ");
            Console.WriteLine(text);
            number++;
        }
    }

    public void CreateGoal()
    {
        Console.WriteLine("The types of Goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type of goal would you like to create? ");
        string answer = Console.ReadLine();

        Console.Write("What is the name of your goal? ");
        string goalName = Console.ReadLine();
        Console.Write("What is a short description of it? ");
        string shortDescription = Console.ReadLine();
        Console.Write("What is the amount of points associated with this goal? ");
        int amountPoints = int.Parse(Console.ReadLine());

        if (answer == "1")
        {
            SimpleGoal simpleGoal = new SimpleGoal(goalName, shortDescription, amountPoints);
            _goals.Add(simpleGoal);
        }
        else if (answer == "2")
        {
            EternalGoal eternalGoal = new EternalGoal(goalName, shortDescription, amountPoints);
            _goals.Add(eternalGoal);
        }
        else if (answer == "3")
        {
            Console.Write("How many times does this goal need to be accomplished for a bonus? ");
            int target = int.Parse(Console.ReadLine());
            Console.Write("What is the bonus for accomplishing it that many times? ");
            int bonus = int.Parse(Console.ReadLine());
            ChecklistGoal checklistGoal = new ChecklistGoal(goalName, shortDescription, amountPoints, target, bonus);
            _goals.Add(checklistGoal);
        }
    }

    public void RecordEvent()
    {
        Console.Write("Which goal did you accomplish? ");
        int index = int.Parse(Console.ReadLine());

        index--;
        Goal goal = _goals[index];

        goal.RecordEvent();
        int points = goal.GetPoints();
        _score += points;

        if (goal is ChecklistGoal && goal.IsComplete())
        {
            _score += ((ChecklistGoal)goal).GetBonus();
        }

        Console.WriteLine($"You now have {_score} points.");
    }

    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
    
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(_level);
            outputFile.WriteLine(_levelName);
            outputFile.WriteLine(_score);

            foreach(Goal goal in _goals)
                {
                    string text = goal.GetStringRepresentation();
                    outputFile.WriteLine(text);
                }
        }
    }
    
    public void LoadGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(fileName);

        int firstLine = int.Parse(lines[0]);
        _level = firstLine;
        string secondLine = lines[1];
        _levelName = secondLine;
        int thirdLine = int.Parse(lines[2]);
        _score = thirdLine;
        
        for (int i = 3; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(',', ':');
        
            string obj = parts[0];
            string name = parts[1];
            string description = parts[2];
            int points = int.Parse(parts[3]);

            if (obj == "SimpleGoal")
            {
                bool isComplete = Convert.ToBoolean(parts[4]);

                SimpleGoal loadedSimpleGoal = new SimpleGoal(name, description, points);
                loadedSimpleGoal.SetIsComplete(isComplete);
                _goals.Add(loadedSimpleGoal);
            }
            else if (obj == "EternalGoal")
            {
                EternalGoal loadedEternalGoal = new EternalGoal(name, description, points);
                _goals.Add(loadedEternalGoal);
            }
            else if (obj == "ChecklistGoal")
            {
                int bonus = int.Parse(parts[4]);
                int target = int.Parse(parts[5]);
                int amountCompleted = int.Parse(parts[6]);

                ChecklistGoal loadedChecklistGoal = new ChecklistGoal(name, description, points, target, bonus);
                loadedChecklistGoal.SetAmountCompleted(amountCompleted);
                _goals.Add(loadedChecklistGoal);
            }
        }
    }
}