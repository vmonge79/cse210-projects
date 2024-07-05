public class ReflectingActivity : Activity

{
    private List<string> _prompts = new List<string> {"Reflect on a moment when you defended someone who needed support.", "Recall a situation where you overcame a significant challenge.", "Remember an instance when you offered assistance to someone struggling.", "Consider a time when you put someone else's needs before your own.", "Think about a time when you made a personal sacrifice for someone else.", "Reflect on a time when you provided comfort to someone in distress.", "Remember an occasion when you went out of your way to help a friend or family member.", "Think of a time when you prioritized your own well-being over others.", "Reflect on a situation where you achieved a personal goal you set for yourself.", "Remember an instance when you took time off to recharge and focus on your mental health."};
    private List<string> _questions = new List<string> {"How did you feel in that moment?", "How do you feel at this very moment when you think about it?", "What did you learn through this experience?", "What is your favortite thing about this experience?", "How was this experience meaningful to you?"};

    public List<string> GetPrompts()
    {
        return _prompts;
    }

    public void SetPrompts(List<string> prompts)
    {
        _prompts = prompts;
    }

    public List<string> GetQuestions()
    {
        return _questions;
    }

    public void SetQuestions(List<string> questions)
    {
        _questions = questions;
    }

    public ReflectingActivity(string name, string description) : base(name, description)
    {

    }

    public string GetRandomPrompt()
    {

        Random randomGenerator = new Random();
        int i = randomGenerator.Next(_prompts.Count);
        return _prompts[i];
    }

    public string GetRandomQuestion()
    {
        Random randomGenerator = new Random();
        int i = randomGenerator.Next(_questions.Count);
        return _questions[i];
    }

    public void DisplayPrompt()
    {
        string prompt = GetRandomPrompt();
        Console.WriteLine(prompt);
    }

    public void DisplayQuestion()
    {
        string question = GetRandomQuestion();
        Console.WriteLine(question);
    }

    public void Run()
    {
        DisplayStartMsg();
        ShowSpinner();
        Console.WriteLine("We'll start in a bit!");
        ShowSpinner();

        DisplayPrompt();
        ShowSpinner();

        DateTime startTime = DateTime.Now; DateTime endTime = startTime.AddSeconds(_duration);

        while (DateTime.Now < endTime)
        {
            DisplayQuestion();
            ShowSpinner();
            ShowSpinner();
        }

        DisplayCloseMsg();

    }



}
