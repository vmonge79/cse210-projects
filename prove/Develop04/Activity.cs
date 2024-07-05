public class Activity

{
    private string _name;
    private string _description;
    public int _duration = 0;



    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetDescription()
    {
        return _description;
    }

    public void Set(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }

    public void Set(int duration)
    {
        _duration = duration;
    }

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;

    }

    public void DisplayStartMsg()
    {
        Console.WriteLine($"Welcome to the {_name}");
        Console.WriteLine($"In the {_name}, {_description}");
        Console.WriteLine("How long, in seconds, would you like to practice today?");
        string userInput = Console.ReadLine();
        _duration = int.Parse(userInput);
        Console.WriteLine($"Great! Let's start your {_duration} seconds practice");
    }

    public void DisplayCloseMsg()
    {
        Console.WriteLine($"Well done! You practiced for {_duration} seconds today!");
    }

    public void ShowSpinner()
    {
        List<string> animStrings = new List<string> { "/", "-", "\\", "|", "/", "-", "\\", "|" };

        foreach (string s in animStrings)
        {
            Console.Write(s);
            Thread.Sleep(500);
            Console.Write("\b\b  \b\b");
        }
    }

    public void ShowCountDown()
    {
        for (int i = 5; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }


}