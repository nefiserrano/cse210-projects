using System;

public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;
    }

    public override void RecordEvent()
    {
        _amountCompleted++;

        if (IsComplete())
        {
            int total = _bonus + _points;
            Console.WriteLine($"Congratulations! You have earned {total} points!");
        }
        else
        {
            Console.WriteLine($"Congratulations! You have earned {_points} points!");
        } 
    }

    public override bool IsComplete()
    {
        if (_amountCompleted >= _target)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public override string GetDetailsString()
    {
        bool isComplete = IsComplete();
        if (isComplete)
        {
            return $"[X] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {_shortName} ({_description}) -- Currently completed: {_amountCompleted}/{_target}";
        }
    }

    public override string GetStringRepresentation()
    {
        string className = GetType().Name;
        return $"{className}:{_shortName},{_description},{_points},{_bonus},{_target},{_amountCompleted}";
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetBonus()
    {
        return _bonus;
    }
}