using System.Runtime.InteropServices.Marshalling;

public class Video
{
    private string _title;
    private string _author;
    private string _length; 
    private List<Comment> comments;

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

    public string GetLength() 
    {
        return _length;
    }

    public void SetLength(string length) 
    {
        _length = length;
    }

    public Video(string author, string title, string length)
    {
        _author = author;
        _title = title;
        _length = length; 
        comments = new List<Comment>(); 
    }

    public int NumberComments()
    {
        return comments.Count;
    }

    public void AddComment(Comment comment)
    {
        comments.Add(comment);
    }

    public List<Comment> GetComments()
    {
        return comments;
    }
}
