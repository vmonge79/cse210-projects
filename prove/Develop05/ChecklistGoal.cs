public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    private int _attempts;

    public int GetAmountCompleted()
    {
        return _amountCompleted;
    }

    public void SetAmountCompleted(int amountCompleted)
    {
        _amountCompleted = amountCompleted;
    }

    public int GetTarget()
    {
        return _target;
    }

    public void SetTarget(int target)
    {
        _target = target;
    }

    public int GetBonus()
    {
        return _bonus;
    }

    public void SetBonus(int bonus)
    {
        _bonus = bonus;
    }

    public int GetAttempts()
    {
        return _attempts;
    }

    public void IncrementAttempts()
    {
        _attempts++;
    }

    public ChecklistGoal(string shortName, string description, int points, int target, int bonus) : base(shortName, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = 0;   
        _attempts = 0;         
    }
}
