using System.ComponentModel;

public abstract class Goal
{
    private string _shortName;
    private string _description;
    private int _points;


    public string GetShortName()
    {
        return _shortName;
    }

    public void SetShortName(string shortName)
    {
        _shortName = shortName;
    }
    public string GetDescription()
    {
        return _description;
    }

    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }
    
    public Goal(string shortName, string description, int points)
    {
        _shortName = shortName;
        _description = description;
        _points = points;

    }
}