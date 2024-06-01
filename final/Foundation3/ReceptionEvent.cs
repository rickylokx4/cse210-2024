using System;

public class RecepetionEvent : Event
{
    private string _email;
    public RecepetionEvent(string eventTitle, string email, string date, string time, string description)
    {
        _eventType = "Reception Event";
        _eventTitle = eventTitle;
        _date = date;
        _time = time;
        _description = description;
        _email = email;
    }
    
    public void DisplayFullDetails()
    {
        Console.WriteLine($"---Full  Details---\n{_eventType}\nEvent: {_eventTitle}\nDescription: {_description}\nDate: {_date} Time: {_time}\nAddress: {_address.GetAddress()}\nRecervetions: {_email}\n");
    }
    
}
