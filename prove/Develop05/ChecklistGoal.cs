using System;
using System.ComponentModel.DataAnnotations.Schema;

class ChecklistGoal : Goal
{
    public ChecklistGoal(string n, string d, int p, bool c, int tc, int b, int bv) : base(n, d, p, c, tc, b, bv){}

    public override string ListGoals(){
        if(completed == false){
            return $"[ ] {name} ({description}) {timesCompleted}/{bonus}";
        }else{
            return $"[X] {name} ({description}) {timesCompleted}/{bonus}";
        }
    }

    public override int RecordGoal(){
        if(completed == false){
            timesCompleted++;
            if(timesCompleted < bonus){
                return pointValue;
            }else{
                completed = true;
                return bonusValue;
            }  
        }else{
            return 0;
        }
    }

    public override string PackagedValues(){
        return $"{name},{description},{pointValue},{completed},{timesCompleted},{bonus},{bonusValue}";
    }
}