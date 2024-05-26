using System;
public class SimpleGoal : Goal
{
    private bool _isComplete;
    private string _goalType = "SimpleGoal";

    public SimpleGoal(string name, string description, string points) : base (name, description,points)
    {
        _isComplete = false;
    }
    public SimpleGoal(string name, string description, string points, bool complete) : base (name, description,points)
    {
        _isComplete = complete;
    }
    public override void RecordEvent()
    {
        Console.WriteLine($"Congratulation you have Earned {_points} points ");
        _isComplete = true;

    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}, {_shortName}, {_description}, {_points}, {_isComplete} ";
    }
}
