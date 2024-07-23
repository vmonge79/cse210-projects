public class Cycling : Exercise
{

    private float _speed;


    public float GetSpeed()
    {
        return _speed;
    }

    public void SetSpeed(float speed)
    {
        _speed  = speed;
    }

    public Cycling (DateTime startTime, DateTime endTime, float speed) : base(startTime, endTime)
    {
        _speed = speed;
    }
    public override float CalculateDistance()
    {
        float distance = CalculateSpeed / 60 * _speed;
        return distance;
    }

    public override float CalculateSpeed()
    {
        return _speed;
    }

}