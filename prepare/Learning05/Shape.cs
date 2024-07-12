using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

public abstract class Shape
{
    private string _color = "";

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

    public Shape(string color) 
    {
        _color = color;
    }

}