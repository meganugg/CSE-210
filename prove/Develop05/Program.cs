using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop05 World!");
        int select = 0;
        int points = 0;
        string input = "";
        while(select != 6){
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("You have", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write($" {points} ", Console.ForegroundColor);
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("points.\n", Console.ForegroundColor);
            Console.WriteLine("Select an option:");
            Console.WriteLine("   1. Create new goal");
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

            switch(select){
                case 1:
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    break;
                case 5:
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