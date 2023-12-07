using System;

abstract class Activity
{
    protected string date;
    protected double duration;
    protected double laps;
    protected double speed;
    protected double distance;

    protected Activity(string dt, double dr, double l){
        date = dt;
        duration = dr;
        laps = l;
    }
    protected Activity(string dt, double dr, double s, int x){
        date = dt;
        duration = dr;
        speed = s;
    }
    protected Activity(string dt, double dr, double d, int x, int x1){
        date = dt;
        duration = dr;
        distance = d;
    }
    public abstract double CalculateDistance();
    public abstract double CalculateSpeed();
    public abstract double CalculatePace();
    public abstract string GetSummary();
}