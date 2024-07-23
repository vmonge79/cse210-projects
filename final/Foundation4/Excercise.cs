public class Exercise 
{
    private DateTime _startTraining;

    private DateTime _endTraining;
    private float _minAct;

    public DateTime GetStartTraining()
    {
        return _startTraining;
    }

    public void SetStartTraining(DateTime startTraining)
    {
        _startTraining = startTraining;
    }

    public DateTime GetEndTraining()
    {
        return _endTraining;
    }

    public void SetEndTraining(DateTime endTraining)
    {
        _endTraining = endTraining;
    }

    public float GetMinAct()
    {
        return _minAct;
    }

    public void SetMinAct(float minAct)
    {
        _minAct = minAct;
    }

    public Exercise(DateTime startTraining, DateTime endTraining)
    {
        _starTraining  = startTraining;
        _endTraining = endTraining;
    }
    
    public void CalculateTrainingMinutes()
    {
        TimeSpan trainingDuration = _endTraining - _startTraining;
        _minAct = (float)trainingDuration.TotalMinutes;
    }
    public virtual float CalculateDistance()
    {
        return 0f;
    }

    public virtual float CalculateSpeed()
    {
        return 0f;
    }

    public float CalculatePace()
    {
        float pace = 60 / CalculateSpeed();
        return pace; ;
    }

    public void GetSummary()
    {
        Console.WriteLine($"Training Summary");
        Console.WriteLine($"Total Excercise Time {_minAct} minutes");
        Console.WriteLine($"Total distance: {CalculateDistance()} meters.");
        Console.WriteLine($"Speed of Workout: {CalculateSpeed()} kilometers per hour.");
        Console.WriteLine($"Pace of Workout: {CalculatePace()} minutes per kilometer.");
    }
}