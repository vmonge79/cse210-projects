public class Event
{
    private string _eventName;
    private string _description;

    private string _date;
    private string _hour;

    private Address _address;


    public string GetEventName()
    {
        return _eventName;
    }

    public void SetEventName(string eventName)
    {
        _eventName = eventName;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public string GetDate()
    {
        return _date;
    }

    public void SetDate(string date)
    {
        _date = date;
    }

    public string GetHour()
    {
        return _hour;
    }

    public void SetTime(string hour)
    {
        _hour = hour;
    }

    public Event(string eventName, string description, Address address, string date, string hour)
    {
        _eventName = eventName;
        _description = description;
        _address = address;
        _date = date;
        _hour = hour;

    }

    public void DisplayDetails()
    {
        Console.WriteLine();
        Console.WriteLine("-----------------------------------");
        Console.WriteLine("EVENT DETAILS");
        Console.WriteLine($"Event: {_eventName}, Description: {_description}");

        
       
    }

    public virtual void DisplayFullDetails()
    {
        DisplayDetails();

        Console.Write("Place"); _address.DisplayAddress();
        Console.WriteLine($"Date: {_date} || Time: {_hour}");
        Console.WriteLine("-----------------------------------");
        Console.WriteLine();

    }

    public void DisplayShortDescription()
    {
        Console.WriteLine();
        Console.WriteLine("EVENT");
        Console.WriteLine($"Event Type: {GetType().Name}, Name: {_eventName} || Time: {_hour}");
        Console.WriteLine("-----------------------------------");


    }
}