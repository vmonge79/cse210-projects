public class Reception : Event
{

    private string _rsvp;

    private Address _address;

    public string GetRSVP()
    {
        return _rsvp;
    }

    public void SetRSVP(string rsvp)
    {
        _rsvp = rsvp;
    }

    public Reception(string eventName, string description, Address address, string rsvp) : base (eventName, description, address)
    {
        _rsvp = rsvp;
    }

}