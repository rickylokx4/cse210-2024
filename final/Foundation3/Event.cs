using System;
public class Event
{
    protected string _eventType;
    protected string _eventTitle;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event()
    {
    }
    public void SetAddress(string streetAddress, string city, string stateOrProvince, string country)
    {
        Address address = new Address(streetAddress, city, stateOrProvince, country);
        _address = address;
    }
    public void DisplayStandarDetails()
    {
        Console.WriteLine($"---Details of the Event---\nEvent: {_eventTitle}\nDescription: {_description}\nDate: {_date} Time: {_time}\nAddress: {_address.GetAddress()}\n");
    }

    public void DisplayShortDescription()
    {
        Console.WriteLine($"---Short  Description---\n{_eventType}\nEvent:{_eventTitle}\nDate: {_date}\n");
    }


}
