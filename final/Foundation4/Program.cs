using System;

class Program
{
    static void Main(string[] args)
    {
        List<Activity> _activitiesList = new List<Activity>();

        RunnigActivity runnigActivity1 = new RunnigActivity("03 Nov 2022", 30, 4.8);
        _activitiesList.Add(runnigActivity1);

        BicycleActivity bicycleActivity1 = new BicycleActivity("03 Nov 2024", 30, 9.6);
        _activitiesList.Add(bicycleActivity1);
        

        SwimmingActivity swimmingActivity1 = new SwimmingActivity("03 Nov 2024", 30, 96);
        _activitiesList.Add(swimmingActivity1);

        RunnigActivity runnigActivity2 = new RunnigActivity("06 MAY 2025", 15, 9.5);
        _activitiesList.Add(runnigActivity2);

        BicycleActivity bicycleActivity2 = new BicycleActivity("07 JUN 2025", 20, 3.8);
        _activitiesList.Add(bicycleActivity2);
        

        SwimmingActivity swimmingActivity2 = new SwimmingActivity("04 JAN 2025", 10, 35);
        _activitiesList.Add(swimmingActivity2);

        foreach(Activity activity in _activitiesList)
        {
            activity.GetSummary();
        }
    }
}