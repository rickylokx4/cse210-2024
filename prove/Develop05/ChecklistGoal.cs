using System;
public class ChecklistGoal : Goal
{
    string _goalType = "CheckListGoal";
    private int _amountComplete;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus) : base (name, description, points)
    {
        _target = target;
        _bonus = bonus;
    }
     public ChecklistGoal(string name, string description, string points, int target, int bonus, int amount) : base (name, description, points)
    {
        _amountComplete = amount;
        _target = target;
        _bonus = bonus;
    }
    public override int GetPoints()
    {
        if (IsComplete()==true)
        {
            return int.Parse(_points) + _bonus;
        }
        else return int.Parse(_points);
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulation you have Earned {_points} points ");
        _amountComplete += 1;
    }

    public override bool IsComplete()
    {   
        if (_amountComplete == _target)
        {
            return true;
        }
        else return false;
    }

    public override string GetDetailsString()
    {
        return $"{_shortName} ({_description} -- currenty completed: {_amountComplete}/{_target})";
    }
    public override string GetStringRepresentation()
    {
        return $"{_goalType}, {_shortName}, {_description}, {_points}, {_bonus}, {_target}, {_amountComplete} ";
    }
}
