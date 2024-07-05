using System.Net;

public class ListingActivity : Activity
{
    private List<string> _prompts = new List<string> {"Who are the people that you love the most?", "Who are the people that love you the most?", "What do you find beautiful in nature?", "When did you feel happy this week?"};
    private int _count = 0;

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }

    public int GetCount()
    {
        return _count;
    }

    public void SetCount(int count)
    {
        _count = count;
    }

    public ListingActivity(string name, string description) : base(name, description)
    {
        
    }

    public void GetRandomPrompt()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(_prompts.Count);
        Console.WriteLine( _prompts[i]);
    }

    public List<string> GetListFromUser()
    {
        return _prompts;
    }

    public void Run()
    {
        DisplayStartMsg();
        ShowSpinner();
        Console.WriteLine("We'll start in a bit!");
        FindEndTime();
        ShowSpinner();

        GetRandomPrompt();
        ShowSpinner();
        Console.WriteLine("List everything that comes to your mind!");

        while (DateTime.Now < _endTime)
        {
            Console.ReadLine();
            _count +=1;
        }
        
        Console.WriteLine($"Great, you made a list of {_count}");
        DisplayCloseMsg();


    }
}