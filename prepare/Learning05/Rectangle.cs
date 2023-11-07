using System;

public class Rectangle : Shape
{
    private double length;
    private double width;

    public Rectangle(string c, double l, double w){
        length = l;
        width = w;
        SetColor(c);
    }
    public override double GetArea()
    {
        return length*width;
    }
}