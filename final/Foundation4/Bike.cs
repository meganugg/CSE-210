using System;
using System.Runtime.InteropServices;

class Bike : Activity
{
    public Bike(string dt, double dr, double x) : base(dt, dr, x){}
    public override double CalculateDistance(){
        return Math.Round(speed*(duration/60), 2);
    }
    public override double CalculateSpeed(){
        return Math.Round(speed, 2);
    }
    public override double CalculatePace(){
        return Math.Round(duration/(speed*(duration/60)), 2);
    }
    public override string GetSummary(){
        return $"{date} - Biking - Distance: {CalculateDistance()}km, Speed: {CalculateSpeed()}km/h, Pace: {CalculatePace()}min/km";
    }
}