using System;

abstract class Activity
{
    protected string date;
    protected double duration;
    protected double laps;
    protected double speed;
    protected double distance;

    protected Activity(string dt, double dr, double x){
        date = dt;
        duration = dr;
        laps = x;
        speed = x;
        distance = x;
    }
    
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract string GetSummary();
}