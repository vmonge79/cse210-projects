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


    public Outdoor(string eventName, string description, Address address, string weather, string date, string hour) : base(eventName, description, address, date, hour)
    {

        _weather = weather;

    }

    public override void DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Expected weather: {_weather}");

    }

}