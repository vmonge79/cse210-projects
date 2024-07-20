public class Reception : Event
{

    private string _rsvp;

    public string GetRSVP()
    {
        return _rsvp;
    }

    public void SetRSVP(string rsvp)
    {
        _rsvp = rsvp;
    }

    public Reception(string eventName, string description, Address address, string rsvp, string date, string hour) : base(eventName, description, address, date, hour)


    {
        _rsvp = rsvp;
    }

}