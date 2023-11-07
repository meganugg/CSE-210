using System;

public class Circle : Shape
{
    private double radius;

    public Circle(string c, double r){
        radius = r;
        SetColor(c);
    }
    public override double GetArea()
    {
        return Math.PI*radius*radius;
    }
}