public class Circle : Shape
{
    private double _radius = 0;

    public double GetRadius()
    {
        return _radius;
    }

    public void SetRadius(double radius)
    {
        _radius = radius;
    }

    public override double GetArea()
    {
        return _radius * _radius * 3.1416;
    }

    public Circle(string color, double radius) : base(color)
    {
        _radius = radius;
    }

}