using System;
using System.Diagnostics;
using System.Globalization;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        int select = 0;
        int select_goal = 0;
        int points = 0;
        int pointValue = 0;
        int number;
        int timesComplete = 0;
        string input = "";
        string name = "";
        string description = "";
        string sPointValue = "";
        string filename = "";
        bool complete = false;
        List<Goal> goals = new List<Goal>();
        Reputation r = new Reputation();
//1st menu
        while(select != 6){
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You have", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {points} ", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("points.\n", Console.ForegroundColor);
            Console.WriteLine("Select an option:");
            Console.WriteLine("   1. Create goals");
            Console.WriteLine("   2. Display goals");
            Console.WriteLine("   3. Save goals");
            Console.WriteLine("   4. Load goals");
            Console.WriteLine("   5. Record event");
            Console.WriteLine("   6. Quit");
            Console.Write(">> ");
            input = Console.ReadLine();
            try{
                select = int.Parse(input);
            }catch{}
//execute menu selection
            switch(select){
                case 1:
                    select_goal = 0;
//2nd menu (submenu of 1)
                    while(select_goal != 4){
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("What type of goal would you like to create?", Console.ForegroundColor);
                        Console.WriteLine("   1. Simple goal");
                        Console.WriteLine("   2. Eternal goal");
                        Console.WriteLine("   3. Checklist goal");
                        Console.WriteLine("   4. Back");
                        Console.Write(">> ");
                        input = Console.ReadLine();
                        try{
                            select_goal = int.Parse(input);
                        }catch{}
//create goal
                        if(select_goal < 4 && select_goal > 0){
                            Console.WriteLine("What is the name of your goal?");
                            Console.Write(">> ");
                            name = Console.ReadLine();
                            Console.WriteLine("Give a short description of your goal.");
                            Console.Write(">> ");
                            description = Console.ReadLine();
                            Console.WriteLine("How many points is this goal worth?");
                            Console.Write(">> ");
                            sPointValue = Console.ReadLine();
                            pointValue = int.Parse(sPointValue);
                        }
                        switch(select_goal){
    //create simple
                            case 1:
                                SimpleGoal s = new SimpleGoal(name, description, pointValue, complete);
                                goals.Add(s);
                                break;
    //create eternal
                            case 2:
                                EternalGoal e = new EternalGoal(name, description, pointValue);
                                goals.Add(e);
                                break;
    //create checklist
                            case 3:
                                Console.WriteLine("How many times must this goal be completed for a bonus?");
                                Console.Write(">> ");
                                string sBonus = Console.ReadLine();
                                int bonus = int.Parse(sBonus);
                                Console.WriteLine("How many points is the completion bonus worth?");
                                Console.Write(">> ");
                                string sBonusValue = Console.ReadLine();
                                int bonusValue = int.Parse(sBonusValue);
                                ChecklistGoal c = new ChecklistGoal(name, description, pointValue, complete, timesComplete, bonus, bonusValue);
                                goals.Add(c);
                                break;
                            case 4:
                            Console.Clear();
                                break;
                            default:
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Enter a valid option", Console.ForegroundColor);
                                break;
                        }
                    }
                    break;
//display goals
                case 2:
                    number = 0;
                    Console.WriteLine();
                    foreach(Goal goal in goals){
                        number++;
                        Console.WriteLine($"{number}. {goal.ListGoals()}");
                    }
                    if(goals.Count() == 0){
                        Console.WriteLine("No goals to display");
                    }
                    break;
//save goals
                case 3:
                    Console.WriteLine("Save to filename:");
                    Console.Write(">> ");
                    filename = Console.ReadLine();
                    r.Save(goals, filename, points);
                    break;
//load goals
                case 4:
                    Console.WriteLine("Load from filename:");
                    Console.Write(">> ");
                    filename = Console.ReadLine();
                    goals.AddRange(r.Load(filename));
                    points += r.GetPoints();
                    break;
//record goal
                case 5:
                    Console.WriteLine("Which event would you like to record?");
                    Console.Write(">> ");
                    string sIndex = Console.ReadLine();
                    try{
                        int index = int.Parse(sIndex);
                        points += goals[index-1].RecordGoal();
                    }catch{
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Enter a valid option", Console.ForegroundColor);
                    }
                    break;
                case 6:
                    Console.Clear();
                    Console.WriteLine("Goodbye");
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Enter a valid option", Console.ForegroundColor);
                    break;
            }
        }
    }
}