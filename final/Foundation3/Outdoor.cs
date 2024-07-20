public class Outdoor : Event
{
    private string _weather;


    public string GetWeather()
    {
        return _weather;
    }

    public void SetWeather(string weather)
    {
        _weather = weather;
    }


    public Outdoor(string eventName, string description, Address address, string weather) : base(eventName, description, address)
    {

        _weather = weather;

    }

    public override DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Expected weather: {_weather}");

    }

}