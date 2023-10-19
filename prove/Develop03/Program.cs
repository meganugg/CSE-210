using System;
using System.ComponentModel.Design;

Console.WriteLine("Hello Develop03 World!");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("NOTE: ", Console.ForegroundColor);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("The Book of Mormon is copyrighted material and has therefore been left out of the library of searchable scriptures in this program\n", Console.ForegroundColor);
string select = "";
string reference = "";
string scripture = "";
Scripture s = new Scripture();
Reference r = new Reference();
while (select != "3")
{
    Console.WriteLine("1. Search");
    Console.WriteLine("2. Enter");
    Console.WriteLine("3. Quit");
    Console.Write("> ");
    select = Console.ReadLine();
    switch (select)
    {
        case ("1"):
            Console.Clear();
            Console.WriteLine("Example: [(n) Xxxxx n:n] or [(n) Xxxxx n:n-n]");
            Console.Write("Scripture: ");
            reference = Console.ReadLine();
            Console.Clear();
            r.setReference(reference);
            if(r.search() == true){
                s.setReference(reference);
                s.setScripture(r.scripture());
                while(s.memorize() != true){
                    s.memorize();
                }
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Scripture(s) not found", Console.ForegroundColor);
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Did your search follow the syntax in the example?", Console.ForegroundColor);
            }
            break;
        case ("2"):
            Console.Clear();
            Console.Write("Reference: ");
            reference = Console.ReadLine();
            Console.Write("Scripture: ");
            scripture = Console.ReadLine();
            Console.Clear();
            s.setReference(reference);
            s.setScripture(scripture);
            while(s.memorize() != true){
                s.memorize();
            }
            break;
        case ("3"):
            Console.Clear();
            Console.WriteLine("Terminating program...");
            break;
        default:
            Console.Clear();
            Console.WriteLine("Select a valid option");
            break;
    }
}
