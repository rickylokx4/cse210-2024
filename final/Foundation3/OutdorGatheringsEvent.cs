using System;

public class OutdoorGateringEvent : Event
{
    private string _weather;
    public OutdoorGateringEvent(string eventTitle, string date, string time, string description, string weather)
    {
        _eventType = "Outdoor Gatherings Event";
        _eventTitle = eventTitle;
        _date = date;
        _time = time;
        _description = description;
        _weather = weather;
    }


public void DisplayFullDetails()
    {
        Console.WriteLine($"---Full  Details---\n{_eventType}\nEvent: {_eventTitle}\nDescription: {_description}\nDate: {_date} Time: {_time}\nAddress: {_address.GetAddress()}\nThe Weather will be {_weather}\n");

    }

}

