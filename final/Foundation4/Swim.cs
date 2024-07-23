public class Swim : Exercise
{

    private int _laps;


    public int GetLaps()
    {
        return _laps;
    }

    public void SetLaps(float laps)
    {
        _laps = laps;
    }

    public Swim(DateTime startTime, DateTime endTime, int laps) : base (startTime, endTime)
    {
        _laps = laps;
    }

    public override float CalculateDistance()
    {
        float distance = _laps * 50;
        return distance;
    }

    public override float CalculateSpeed()
    {
        float distance = CalculateDistance();
        float speed = (distance/ _minAct) * 60;
        return speed;
    }

}