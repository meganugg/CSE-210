using System;
using System.Threading.Channels;

public abstract class Goal
{
    protected string name;
    protected string description;
    protected int pointValue;
    protected int bonus;
    protected int bonusValue;
    protected int timesCompleted;
    protected bool completed;

    protected Goal(string n, string d, int p){
        name = n;
        description = d;
        pointValue = p;
    }
    protected Goal(string n, string d, int p, bool c){
        completed = c;
        name = n;
        description = d;
        pointValue = p;
    }
    protected Goal(string n, string d, int p, bool c, int tc, int b, int bv){
        name = n;
        description = d;
        pointValue = p;
        bonus = b;
        bonusValue = bv;
        completed = c;
        timesCompleted = tc;
    }

    public abstract string PackagedValues();
    public abstract string ListGoals();
    public abstract int RecordGoal();
}