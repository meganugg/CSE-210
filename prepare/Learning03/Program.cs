using System;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        int select = 0;
        while(select != 2){
            Console.WriteLine("1. Fraction / Decimal");
            Console.WriteLine("2. Quit");
            Console.Write("> ");
            String selectString = Console.ReadLine();
            select = int.Parse(selectString);
            switch(select){
                case (1):
                    Console.Write("Enter a numerator: ");
                    String ns = Console.ReadLine();
                    int n = int.Parse(ns);
                    Console.Write("Enter a denominator: ");
                    String ds = Console.ReadLine();
                    int d = int.Parse(ds);
                    Fraction f = new Fraction(n, d);
                    Console.WriteLine(f.getFractionString());
                    Console.WriteLine(f.getFractionDecimal());
                    break;
                case (2):
                    break;
                default:
                    Console.WriteLine("Select an option");
                    break;
            }
        }
    }
}