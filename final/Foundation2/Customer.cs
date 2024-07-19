public class Customer
{
    private string _name;



    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public Customer(string name)
    {
        _name = name;
    }
}