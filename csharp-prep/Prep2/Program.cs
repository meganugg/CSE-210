using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep2 World!");
        Console.WriteLine("What is your grade percentage? ");
        String percentage_text = Console.ReadLine();
        float percentage = float.Parse(percentage_text);

        String letter = "";
        bool pass = false;
        if(percentage >= 90){
            letter = "A";
            pass = true;
        }else if(percentage >= 80 && percentage < 90){
            letter = "B";
            pass = true;
        }else if(percentage >= 70 && percentage < 80){
            letter = "C";
            pass = true;
        }else if(percentage >= 60 && percentage < 70){
            letter = "D";
        }else{
            letter = "F";
        }
        Console.WriteLine($"Your letter grade is a(n) {letter}");
        if(pass){
            Console.WriteLine("Congratulations! You passed!");
        }else{
            Console.WriteLine("You did not pass, unfortunately. Study hard! You can do it, you're smart enough!");
        }
    }
}