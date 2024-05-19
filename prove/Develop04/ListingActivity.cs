using System;
using System.Net;

class ListingActivity : Activity
{
    private int _count;
    private List<string> _prompts = new List<string>
    {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "Who are people that you have helped this week?",
        "When have you felt the Holy Ghost this month?",
        "Who are some of your personal heroes?",
    };

    public ListingActivity()
    {
        _name = "Listing";
        _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    }
    public void Run()
    {
        Console.WriteLine("How long, in seconds, would you like for your session? ");
        int seconds = int.Parse(Console.ReadLine());
        _duration = seconds;
        Console.WriteLine("\nGet ready");
        ShowSpinner(5);
        Console.WriteLine("\nList as many responses you can to the following prompt: ");
        GetRandomPrompt();
        Console.Write("\nYou Begin in: ");
        ShowCountDown(5);
        Console.Write("\n");
        DateTime starTime = DateTime.Now;
        DateTime endTime = starTime.AddSeconds(seconds);
        
        while (DateTime.Now < endTime)
        {   
            Console.Write(">");
            GetListFromUser();
            _count++;
        }
        Console.Write($"You listed {_count} items: ");
        
    }
    public void GetRandomPrompt()
    {
        Random random = new Random();
        int index = random.Next(_prompts.Count);
        Console.WriteLine($"--- {_prompts[index]} ---");
    }
    public List<string> GetListFromUser()
    {
        List<string> responses = new List<string>();
        responses.Add(Console.ReadLine());
        return responses;
    }
}