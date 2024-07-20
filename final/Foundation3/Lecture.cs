public class Lecture : Event
{
    private string _speaker;
    private int _capacity;


    public string GetSpeaker()
    {
        return _speaker;
    }

    public void SetSpeaker(string speaker)
    {
        _speaker = speaker;
    }

    public int GetCapacity()
    {
        return _capacity;
    }

    public void SetCapacity(int capacity)
    {
        _capacity = capacity;
    }


    public Lecture(string eventName, string description, Address address, string speaker, int capacity) : base(eventName, description, address)
    {
        _speaker = speaker;
        _capacity = capacity;

    }

    public override DisplayFullDetails()
    {
        base.DisplayFullDetails();
        Console.WriteLine($"Speaker: {_speaker} || Capacity: Maximum {_capacity} people");

    }

}