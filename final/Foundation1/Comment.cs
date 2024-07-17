public class Comment
{

    private string _comment;
    private string _name;


    public string GetComment()
    {
        return _comment;
    }

    public void SetComment(string comment)
    {
        _comment = comment;
    }

    public string GetName()
    {
        return _name;
    }

    public void GetName(string name)
    {
        _name = name;
    }

    public Comment(string name, string comment)
    {
        _name = name;
        _comment = comment;
    }

    public void ShowComment()
    {
        Console.WriteLine($"{_comment}, by {_name}");
    }


}