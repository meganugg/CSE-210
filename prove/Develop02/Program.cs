using System;
using System.ComponentModel.Design;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Develop02 World!");
        int select = 0;
        Random random = new Random();
        Journal journal = new Journal();

        while(select != 5){
        Console.WriteLine("");
        Console.WriteLine("Select an option");
        Console.WriteLine("     1. New entry");
        Console.WriteLine("     2. Display");
        Console.WriteLine("     3. Save");
        Console.WriteLine("     4. Load");
        Console.WriteLine("     5. Quit");
        Console.Write(">> ");

        String select_string = Console.ReadLine();
        select = int.Parse(select_string);


            if(select == 1){
                int index = random.Next(0, 11);
                Entry entry = new Entry();
                    entry.date = DateTime.Now.ToShortDateString();
                    entry.prompt = index;
                    entry.displayPrompt();
                    Console.Write("> ");
                    entry.entry = Console.ReadLine();
                    journal.entries.Add(entry);
            }
            else if(select == 2){
                journal.display();
            }
            else if(select == 3){
                Console.WriteLine("Enter a file name (inlcude file extension)");
                Console.Write("> ");
                journal.filename = Console.ReadLine();
                journal.save();
                Console.WriteLine("File saved.");
            }
            else if(select == 4){
                Console.WriteLine("Enter a file name (inlcude file extension)");
                Console.Write("> ");
                journal.filename = Console.ReadLine();
                journal.load();
                Console.WriteLine("File loaded.");
            }
            else if(select == 5){}
            else{
                Console.WriteLine("Enter a valid option.");
            }
        }
    }
}