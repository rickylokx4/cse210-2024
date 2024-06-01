using System;
using System.Diagnostics;

public class LecturesEvent : Event 
{
    private string _speaker;
    private int _capacityLimit;
    public LecturesEvent(string eventTitle, string speaker, int capacityLimit, string date, string time, string description)
    {
        _eventType = "Lectures Event";
        _eventTitle = eventTitle;
        _speaker = speaker;
        _capacityLimit = capacityLimit;
        _date = date;
        _time = time;
        _description = description;
    }
   

    public void DisplayFullDetails()
    {
        Console.WriteLine($"---Full Details---\n{_eventType}\nEvent: {_eventTitle}\nDescription: {_description}\nSpeaker: {_speaker} \nDate: {_date} Time: {_time}\nAddress: {_address.GetAddress()}\nCapacity: {_capacityLimit} people.\n");
    }
    
}
