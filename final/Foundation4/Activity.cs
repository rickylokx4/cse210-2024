using System;

public abstract class Activity
{
    protected string _activityName;
    private string _date;
    protected double _length;
    
    public Activity(string date, int length)
    {
        _date = date;
        _length = length;
    }
    
    public abstract double GetDistance();
    
    public virtual double GetSpeed()
    {
        return GetDistance() / _length * 60;
    }
    public virtual double GetPace()
    {
        return 60 / GetSpeed();
    }
    public void GetSummary()
    {
        Console.WriteLine($"{_date} {_activityName} ({_length} min) - Distance {Math.Round(GetDistance(), 2)} Km, Speed {Math.Round(GetSpeed(),2)} kph, Peace: {Math.Round(GetPace(),2)} min per km ");
    }
}