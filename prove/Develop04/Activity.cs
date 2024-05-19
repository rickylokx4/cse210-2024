
using System;
using System.Runtime.CompilerServices;

class Activity
{
    protected string _name;
    protected string _description;
    protected int _duration;

    public Activity()
    {

    }

    public void DisplayStaringMessage()
    {
        Console.WriteLine($"\nWelcome to the {_name} activity\n\n{_description}");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("\n\nWell done!!");
        ShowSpinner(4);
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} activity.");
        ShowSpinner(4);
        Console.Clear();
    }

    public void ShowSpinner(int seconds)
    {   
        List<string> animations = new List<string>
        {
            "|", "/", "-", "\\","|", "/", "-", "\\"
        };

        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(seconds);

        int i = 0;

        while (DateTime.Now < endTime)
        {
            string s = animations[i];
            Console.Write(s);
            Thread.Sleep(1000);
            Console.Write("\b \b");

            i++;

            if (i >= animations.Count)
            {
                i = 0;
            }
        }
    }

    public void ShowCountDown(int seconds)
    {
       for (int i = seconds; i > 0 ; i--)
       {
        Console.Write(i);
        Thread.Sleep(1000);
        Console.Write("\b \b");
       }
    }
}
