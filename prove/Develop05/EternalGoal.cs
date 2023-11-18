using System;

class EternalGoal : Goal
{
    public EternalGoal(string n, string d, int p) : base(n, d, p){}

    public override string ListGoals(){
        return $"[-] {name} ({description})";
    }

    public override int RecordGoal(){
        return pointValue;
    }

    public override string PackagedValues(){
        return $"{name},{description},{pointValue}";
    }
}