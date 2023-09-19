using System;
using System.Transactions;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep5 World!");
        DisplayWelcome();
        String name = PromptUserName();
        int num = PromptUserNumber();
        int square = SquareNumber(num);
        DisplayResult(name, square);
    }
    static void DisplayWelcome(){
        Console.WriteLine("Welcome to the program!");
    }
    static String PromptUserName(){
        Console.Write("Enter your name: ");
        String name = Console.ReadLine();
        return name;
    }
    static int PromptUserNumber(){
        Console.Write("Enter your favorite number: ");
        String number_string = Console.ReadLine();
        int number = int.Parse(number_string);
        return number;
    }
    static int SquareNumber(int n){
        return n*n;
    }
    static void DisplayResult(String name, int n){
        Console.WriteLine($"{name}, the square of your number is {n}");
    }
}