using System;

public class Square : Shape
{
    private double side;
    public Square(string c, double s){
        side = s;
        SetColor(c);
    }

    public override double GetArea(){
        return side*side;
    }
}