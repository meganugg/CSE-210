using System;
using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop04 World!");
        string input = "";
        int select = 0;
        Activity a = new Activity();
        while(select != 4){
            Console.WriteLine("Select an exercise");
            Console.WriteLine("   1. Breathing Activity");
            Console.WriteLine("   2. Reflection Activity");
            Console.WriteLine("   3. Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("> ");
            input = Console.ReadLine();
            try{
                select = int.Parse(input);
            }catch{
                Console.WriteLine("Enter a valid option");
            }

            switch(select){
                case 1:
                    Console.Clear();
                    BreathingActivity breathe = new BreathingActivity();
                    breathe.Run();
                    break;
                case 2:
                    Console.Clear();
                    ReflectionActivity reflect = new ReflectionActivity();
                    reflect.Run();
                    break;
                case 3:
                    Console.Clear();
                    ListingActivity list = new ListingActivity();
                    list.Run();
                    break;
                default:
                    break;
            }
        }
    }
}