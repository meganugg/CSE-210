using System;

class SimpleGoal : Goal
{
    public SimpleGoal(string n, string d, int p, bool c) : base(n, d, p, c){}
    public override string ListGoals(){
        if(completed == false){
            return $"[ ] {name} ({description})";
        }else{
            return $"[X] {name} ({description})";
        }
        
    }

    public override int RecordGoal(){
        if(completed == false){
            completed = true;
            return pointValue;
        }else{
            return 0;
        }
    }

    public override string PackagedValues(){
        return $"{name},{description},{pointValue},{completed}";
    }
}