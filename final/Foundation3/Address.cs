public class Address
{

    private string _city;
    private string _state;

    public string GetCity()
    {
        return _city;
    }

    public void SetCity(string city)
    {
        _city = city;
    }

    public string Getstate()
    {
        return _state;
    }

    public void SetState(string state)
    {
        _state = state;
    }

    public Address(string city, string state)
    {
       
        _city = city;
        _state = state;
    

    }
    public void DisplayAddress()
    {
        Console.WriteLine($"{_city}, {_state}");
    }


}