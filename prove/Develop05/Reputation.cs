using System;
using System.IO;

class Reputation
{
    private int points;
    public void Save(List<Goal> goals, string f, int p){
        using(StreamWriter outputFile = new StreamWriter(f)){
            foreach(Goal goal in goals){
                outputFile.WriteLine(goal.PackagedValues());
            }
            outputFile.WriteLine(p);
        }
    }

    public List<Goal> Load(string f){
        List<Goal> g = new List<Goal>();
        string[] lines = System.IO.File.ReadAllLines(f);
        foreach(string line in lines){
            string[] elements = line.Split(",");
            if(elements.Count() == 3){
                EternalGoal e = new EternalGoal(elements[0], elements[1], int.Parse(elements[2]));
                g.Add(e);
            }else if(elements.Count() == 4){
                SimpleGoal s = new SimpleGoal(elements[0], elements[1], int.Parse(elements[2]), Convert.ToBoolean(elements[3]));
                g.Add(s);
            }else if(elements.Count() == 7){
                ChecklistGoal c = new ChecklistGoal(elements[0], elements[1], int.Parse(elements[2]), Convert.ToBoolean(elements[3]), int.Parse(elements[4]), int.Parse(elements[5]), int.Parse(elements[6]));
                g.Add(c);
            }else{
                points = int.Parse(elements[0]);
            }
        }
        return g;
    }

    public int GetPoints(){
        return points;
    }
}