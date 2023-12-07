using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation4 World!");
        List<Activity> activities = new List<Activity>();
        Run r = new Run("01/08/2024", 30, 8, 0, 0);
        Bike b = new Bike("01/09/2024", 65, 28, 0);
        Swim s = new Swim("01/10/2024", 55, 36);
        activities.Add(r);
        activities.Add(b);
        activities.Add(s);

        foreach(Activity activity in activities){
            Console.WriteLine(activity.GetSummary());
        }
    }
}