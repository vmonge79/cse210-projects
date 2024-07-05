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
        ShowSpinner();

        DateTime startTime = DateTime.Now;DateTime endTime = startTime.AddSeconds(_duration);
        
        while (DateTime.Now < endTime)

        {
            Console.WriteLine("Breath in, for 5 seconds");
            ShowCountDown();
            Console.WriteLine("Hold your breath for 5 seconds");
            ShowCountDown();
            Console.WriteLine("Breath out, for 5 seconds");
            ShowCountDown();
        }

        DisplayCloseMsg();
    }
}