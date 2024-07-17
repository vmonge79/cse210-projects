using System.Runtime.InteropServices.Marshalling;

public class Video
{
    private string _title;
    private string _author;

    private string _lenght;

    public List<Comment> comments;

    public string GetTitle()
    {
        return _title;
    }

    public void SetTitle(string title)
    {
        _title = title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public void SetAuthor(string author)
    {
        _author = author;
    }

    public string GetLenght()
    {
        return _lenght;
    }

    public void SetLenght(string lenght)
    {
        _lenght = lenght;
    }

    public Video(string author, string title, string lenght)
    {
        _author = author;
        _title = title;
        _lenght = lenght;
        comments = new List<Comment>();

    }

    public int NumberComments()
    {
        return comments.Count();
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

}