using System.Security.Cryptography.X509Certificates;

public class Entry
{
    public string _date = "";
    public string _promptText = "";
    public string _entryText = "";
    

    public Entry()
    {
    
    }

    public string EntryGetDate()
    {
        DateTime today = DateTime.Now;
        return today.ToShortDateString();
    }
    public void Display()
    {
        Console.WriteLine($"{_date}: {_promptText} > {_entryText}");
    }

}