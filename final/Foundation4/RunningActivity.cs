using System;

public class RunnigActivity : Activity
{
    private double _distance;
    public RunnigActivity (string date, int length, double distance) : base (date, length)
    {
        _activityName = "Running";
        _distance = distance;
    }

    public override double GetDistance()
    {
        return _distance;
    }
    // public override double GetSpeed()
    // {
    //     return GetDistance() / _length * 60;
    // }
    // public override double GetPace()
    // {
    //     return 60 / GetSpeed();
    // }
}