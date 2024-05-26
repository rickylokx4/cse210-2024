using System;
public class EternalGoal : Goal
{   
    string _goalType = "EternalGoal";
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }
    public override void RecordEvent()

    {
        Console.WriteLine($"Congratulation you have Earned {_points} points ");
    }

    public override bool IsComplete()
    {
        return false;
    }

    public override string GetStringRepresentation()
    {
        return $"{_goalType}, {_shortName}, {_description}, {_points}";
    }
}
