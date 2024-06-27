public class PromptGen
{
    public string Description { get; set; }
    public List<string> _prompts = new List<string>() 
    { 
        "What was your favorite moment of the day?",
         "Describe what did you like the most toay:",
         "What was your biggest achievement today?:",
         "Write about a pivotal moment in your day:",
         "What are you most grateful for?:",
         "Describe a time today when you felt happy:",
         "What is one thing you learned today?:",
         "Describe a person who has inspired you today:",
};

    public PromptGen()
    {
    }

    public string DisplayRandomPrompt()
    {
        
            Random randomGenerator = new Random();
            int i = randomGenerator.Next(_prompts.Count);
            Console.WriteLine($"{i}");
            return _prompts[i];
        }
      
}
