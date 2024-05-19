using System;

class BreathingActivity : Activity
{
    public BreathingActivity()
    {
        _name = "Breathing";
        _description = "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing";
    }   
    public void Run()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
        Console.WriteLine("Get ready");
        ShowSpinner(5);

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {
            Console.Write($"\n\nbreathe in...");
            ShowCountDown(4);
            Console.Write($"\nNow breathe out...");
            ShowCountDown(4);
        }
        
        
        
    }
}
