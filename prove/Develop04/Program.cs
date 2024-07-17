using System;
using System.Xml.Serialization;

class Program
{
    static void Main(string[] args)
    {
        
        string choice;
        
        DateTime startTime = DateTime.Now;

        BreathingActivity act01 = new BreathingActivity("Breathing Activity", "You will have the opportunity to focus your attention on your breathing, allowing you to find a space of concentration and calm that will aid you in your mindfulness practice.");

        ReflectingActivity act02 = new ReflectingActivity("Reflecting Activity", "You will have the opportunity to reflect on significant moments in your life and connect with the emotions and lessons you have gained from those experiences.");

        ListingActivity act03 = new ListingActivity("Reflecting Activity", "You'll be able to bring to your awareness moments that have had a special impact on you, thus cultivating your gratitude in a more mindful way.");

        do
        {
        Console.WriteLine("Welcome to your mindful practice!");
        Console.WriteLine("Please select a choice from the menu:");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Quit");
        
        choice = Console.ReadLine();

        if (choice == "1")
        {
            act01.Run();
        }

        else if (choice == "2")
        {
            act02.Run();
        }

        else if (choice == "3")
        {
            act03.Run();
        }

        else if (choice == "4")
        {
            Console.WriteLine("See you next time");
        }

        else 
        {
            Console.WriteLine("Please select a valid number 1, 2, 3 or 4.");
        }
        
    
        }
        
        while (choice != "0");
        
    }
    
}