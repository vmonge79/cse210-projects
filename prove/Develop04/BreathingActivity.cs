public class BreathingActivity : Activity
{
    public BreathingActivity(string name, string description) : base (name, description)
    {
        
    }

    public void Run()
    {
        DisplayStartMsg();
        ShowSpinner();
        Console.WriteLine("We'll start in a bit!");
        FindEndTime();
        ShowSpinner();
        
        while (DateTime.Now < _endTime)
        {
            Console.WriteLine("Breath in, for 5 seconds");
            ShowCountDown();
            Console.WriteLine("Hold your breath for 5 seconds");
            ShowCountDown();
            Console.WriteLine("Breath out, for 5 seconds");
            ShowCountDown();
        }

        ShowSpinner();
        DisplayCloseMsg();
    }
}