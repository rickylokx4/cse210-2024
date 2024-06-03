using System;

public class SwimmingActivity : Activity
{
    private double _laps;

    public SwimmingActivity(string date, int length, int laps) : base (date, length)
    {
        _activityName = "Swimming";
        _laps = laps;
    }
    public override double GetDistance()
    {
        return _laps * 50 / 1000;
    }
    // public override double GetSpeed()
    // {
    //     return GetDistance()  / _length * 60 ;
    // }
    // public override double GetPace()
    // {
    //     return 60 / GetSpeed();
    // }

}