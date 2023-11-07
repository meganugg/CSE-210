using System;

public abstract class Shape
{
    private string color;

    public void SetColor(string c){
        color = c;
    }
    public string GetColor(){
        return color;
    }

    public virtual double GetArea(){
        return 0;
    }
}