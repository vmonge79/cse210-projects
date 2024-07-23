public class Running : Exercise
{
    private float _distance;


    public float GetDistance()
    {
        return _distance;
    }

    public void SetDistance(float distance)
    {
        _distance = distance;
    }

    public Running(DateTime startTime, DateTime endTime, float distance) : base(startTime, endTime)
    {
        _distance = distance;
    }

    public override float CalculateDistance()
    {
        return _distance;
    }

    public override float CalculateSpeed()
    {
        float speed = (distance / _minAct) * 60;
        return speed;
    }

}