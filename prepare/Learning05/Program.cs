using System;
using System.Collections.ObjectModel;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        Square square1 = new Square("red", 12);
       
        Rectangle rect1 = new Rectangle("blue", 10, 5);
       
        Circle circ1 = new Circle("black", 8);
        

        List<Shape> shapes = new List<Shape>{square1, rect1, circ1};

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"The {shape} is {shape.GetColor()} and has an area of {shape.GetArea()} cm2.");
        }

    }
}