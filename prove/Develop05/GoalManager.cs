using System.Runtime.CompilerServices;

public class GoalManager
{
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
        Console.WriteLine("What is a short decription of it?");
        string description = Console.ReadLine();
        Console.WriteLine("What is the amount od points associated with this goal?");
        string pointsInput = Console.ReadLine();
        int points = int.Parse(pointsInput);
        goal.SetPoints(points);

    }


}