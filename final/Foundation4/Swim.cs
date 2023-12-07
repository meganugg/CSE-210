using System;

class Swim : Activity
{
    public Swim(string dt, double dr, double l) : base(dt, dr, l){}
    public override double CalculateDistance(){
        return Math.Round(laps*50, 2);
    }
    public override double CalculateSpeed(){
        return Math.Round((laps*50/1000)/(duration/60), 2);
    }
    public override double CalculatePace(){
        return Math.Round(duration/(laps*50/1000), 2);
    }
    public override string GetSummary(){
        return $"{date} - Swimming - Distance: {CalculateDistance()}m, Speed: {CalculateSpeed()}km/h, Pace: {CalculatePace()}min/km";
    }
}