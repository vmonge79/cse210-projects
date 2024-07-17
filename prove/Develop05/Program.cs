using System;
using System.Formats.Asn1;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        string response;
        string goalType;

        GoalManager goalManager = new GoalManager();

        do
        {
            Console.WriteLine("Select a choice from the menu");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List goals");
            Console.WriteLine("3. Save goals");
            Console.WriteLine("4. Load goals");
            Console.WriteLine("5. Record event");
            Console.WriteLine("6. Quit");

            response = Console.ReadLine();

            if (response == "1")
            {
                Console.WriteLine("What type of goal would you like to create?:");
                Console.WriteLine("1. Simple goal");
                Console.WriteLine("2. Eternal goal");
                Console.WriteLine("3. Checklist goal");
                goalType = Console.ReadLine();

                if (goalType == "1")
                {
                    SimpleGoal simplegoal = new SimpleGoal("", "", 0);
                    goalManager.CreateGoal(simplegoal);
                }
                else if (goalType == "2")
                {
                    EternalGoal eternalgoal = new EternalGoal("", "", 0);
                    goalManager.CreateGoal(eternalgoal);
                }
                else if (goalType == "3")
                {
                    ChecklistGoal checklistgoal = new ChecklistGoal("", "", 0, 0, 0);
                    goalManager.CreateCheckListGoal(checklistgoal);
                }
                else
                {
                    Console.WriteLine("Please choose a valid option.");
                }
            }
            else if (response == "2")
            {
                goalManager.ListGoals();
            }
            else if (response == "3")
            {
                goalManager.SaveGoals("goals.txt");
            }
            else if (response == "4")
            {
                goalManager.LoadGoals("goals.txt");
            }
            else if (response == "5")
            {
                goalManager.LoadGoalsIndex("goals.txt");
                int goalSelected = 0;
                string choice = Console.ReadLine();
                if (int.TryParse(choice, out goalSelected) && goalSelected > 0 && goalSelected <= goalManager.goals.Count)
                {
                    goalManager.RecordEvent(goalSelected);
                }
                else
                {
                    Console.WriteLine("Invalid selection. Please choose a valid goal index.");
                }
            }
        } while (response != "6");
    }
}
