using System;
using System.ComponentModel.Design;

Console.WriteLine("Hello Develop03 World!");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.Write("NOTE: ", Console.ForegroundColor);
Console.ForegroundColor = ConsoleColor.White;
Console.WriteLine("The Book of Mormon is copyrighted material and has therefore been left out of the library of searchable scriptures in this program\n", Console.ForegroundColor);
String select = "";
String reference = "";
String scripture = "";
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
            Console.Write("Scripture: ");
            reference = Console.ReadLine();
            Reference r = new Reference();
            r.setReference(reference);
            if(r.search() == true){
                Scripture s = new Scripture(r.scripture());
            }else{
                Console.WriteLine("Scripture(s) not found");
            }
            break;
        case ("2"):
            Console.Clear();
            Console.Write("Reference: ");
            reference = Console.ReadLine();
            break;
        case ("3"):
            Console.Clear();
            Console.WriteLine("Terminating program...");
            break;
        default:
            Console.WriteLine("Select a valid option");
            break;
    }
}
