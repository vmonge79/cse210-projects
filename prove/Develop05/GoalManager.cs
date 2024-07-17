using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

using System;
using System.Collections.Generic;
using System.IO;

public class GoalManager
{
    public List<Goal> goals = new List<Goal>();
    private int _score;

    public int GetScore()
    {
        return _score;
    }

    public void SetScore(int score)
    {
        _score = score;
    }

    public void CreateGoal(Goal goal)
    {
        Console.WriteLine("What is the name of your goal?");
        string shortName = Console.ReadLine();
        goal.SetShortName(shortName);
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        goal.SetDescription(description);
        string pointsInput = Console.ReadLine();
        int points = int.Parse(pointsInput);
        goal.SetPoints(points);

        goals.Add(goal);
        SaveGoals("goals.txt");
    }

    public void CreateCheckListGoal(ChecklistGoal goal)
    {
        Console.WriteLine("What is the name of your goal?");
        string shortName = Console.ReadLine();
        goal.SetShortName(shortName);
        Console.WriteLine("What is a short description of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount of points associated with this goal?");
        goal.SetDescription(description);
        string pointsInput = Console.ReadLine();
        int points = int.Parse(pointsInput);
        goal.SetPoints(points);
        Console.WriteLine("How many times does this goal need to be accomplished for a bonus?");
        string timesInput = Console.ReadLine();
        int target = int.Parse(timesInput);
        goal.SetTarget(target);
        Console.WriteLine("What is the bonus for accomplishing it that many times?");
        string bonusInput = Console.ReadLine();
        int bonus = int.Parse(bonusInput);
        goal.SetBonus(bonus);

        goals.Add(goal);
        SaveGoals("goals.txt");
    }

    public void ListGoals()
    {
        foreach (Goal goal in goals)
        {
            string goalType = goal switch
            {
                SimpleGoal => "Simple",
                EternalGoal => "Eternal",
                ChecklistGoal => "Checklist",
                _ => "Unknown"
            };

            string goalDetails = $"Type: {goalType}, Name: {goal.GetShortName()}, Description: {goal.GetDescription()}, Points: {goal.GetPoints()}";

            if (goal is ChecklistGoal checklistGoal)
            {
                goalDetails += $", Target: {checklistGoal.GetTarget()}, Bonus: {checklistGoal.GetBonus()}";
            }

            Console.WriteLine(goalDetails);
        }
    }

    public void SaveGoals(string filename)
    {
        Console.WriteLine("Saving...");

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Goal goal in goals)
            {
                string goalType = goal switch
                {
                    SimpleGoal => "Simple",
                    EternalGoal => "Eternal",
                    ChecklistGoal => "Checklist",
                    _ => "Unknown"
                };

                string goalDetails = $"Type: {goalType}, Name: {goal.GetShortName()}, Description: {goal.GetDescription()}, Points: {goal.GetPoints()}";

                if (goal is ChecklistGoal checklistGoal)
                {
                    goalDetails += $", Target: {checklistGoal.GetTarget()}, Bonus: {checklistGoal.GetBonus()}";
                }

                outputFile.WriteLine(goalDetails);
            }

            outputFile.WriteLine($"Total Score: {_score}");
        }
    }

    public void LoadGoals(string filename)
    {
        Console.WriteLine("Loading...");

        goals.Clear();

        string[] lines = File.ReadAllLines(filename);

        foreach (string line in lines)
        {
            string[] parts = line.Split(',');
            string type = parts[0].Split(':')[1].Trim();
            string shortName = parts[1].Split(':')[1].Trim();
            string description = parts[2].Split(':')[1].Trim();
            int points = int.Parse(parts[3].Split(':')[1].Trim());

            if (type == "Simple")
            {
                SimpleGoal goal = new SimpleGoal(shortName, description, points);
                goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                EternalGoal goal = new EternalGoal(shortName, description, points);
                goals.Add(goal);
            }
            else if (type == "Checklist")
            {
                int target = int.Parse(parts[4].Split(':')[1].Trim());
                int bonus = int.Parse(parts[5].Split(':')[1].Trim());
                ChecklistGoal goal = new ChecklistGoal(shortName, description, points, target, bonus);
                goals.Add(goal);
            }
        }

        ListGoals();
    }

    public void LoadGoalsIndex(string filename)
    {
        Console.WriteLine("Choose the goal:");

        string[] lines = File.ReadAllLines(filename);

        goals.Clear();

        int i = 1;
        foreach (string line in lines)
        {
            if (line.StartsWith("Total Score:"))
            {
                _score = int.Parse(line.Split(':')[1].Trim());
                continue;
            }

            string[] parts = line.Split(',');
            string type = parts[0].Split(':')[1].Trim();
            string shortName = parts[1].Split(':')[1].Trim();
            string description = parts[2].Split(':')[1].Trim();
            int points = int.Parse(parts[3].Split(':')[1].Trim());

            if (type == "Simple")
            {
                SimpleGoal goal = new SimpleGoal(shortName, description, points);
                goals.Add(goal);
            }
            else if (type == "Eternal")
            {
                EternalGoal goal = new EternalGoal(shortName, description, points);
                goals.Add(goal);
            }
            else if (type == "Checklist")
            {
                int target = int.Parse(parts[4].Split(':')[1].Trim());
                int bonus = int.Parse(parts[5].Split(':')[1].Trim());
                ChecklistGoal goal = new ChecklistGoal(shortName, description, points, target, bonus);
                goals.Add(goal);
            }

            Console.WriteLine($"{i++}. {line}");
        }
    }

    public void RecordEvent(int goalIndex)
    {
        Goal selectedGoal = goals[goalIndex - 1];

        if (selectedGoal is SimpleGoal simpleGoal)
        {
            simpleGoal.SetIsComplete(true);
            _score += simpleGoal.GetPoints();
            Console.WriteLine("Simple goal completed!");
        }
        else if (selectedGoal is EternalGoal eternalGoal)
        {
            _score += eternalGoal.GetPoints();
            Console.WriteLine("Eternal goal recorded!");
        }
        else if (selectedGoal is ChecklistGoal checklistGoal)
        {
            checklistGoal.IncrementAttempts();
            _score += checklistGoal.GetPoints();

            Console.WriteLine($"Checklist goal attempts: {checklistGoal.GetAttempts()}/{checklistGoal.GetTarget()}");

            if (checklistGoal.GetAmountCompleted() >= checklistGoal.GetTarget())
            {
                _score += checklistGoal.GetBonus();
                Console.WriteLine("Checklist goal completed! Bonus points awarded!");
            }
            else
            {
                Console.WriteLine("Checklist goal progress recorded!");
            }
        }
    }
}