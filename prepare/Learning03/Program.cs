using System;
using System.Data;
using System.Xml.Schema;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
        int select = 0;
        while(select != 2){
            bool err1 = false;
            bool err2 = false;
            int n = 0;
            int d = 0;
            Console.WriteLine("1. Fraction / Decimal");
            Console.WriteLine("2. Quit");
            Console.Write("> ");
            String selectString = Console.ReadLine();
            try{
                select = int.Parse(selectString);
            }catch{
                Console.WriteLine("Select an option");
            }
            switch(select){
                case (1):
                    Console.Write("Enter a numerator: ");
                    String ns = Console.ReadLine();
                    try{
                        n = int.Parse(ns);
                    }catch{
                        err1 = true;
                    }
                    Console.Write("Enter a denominator: ");
                    String ds = Console.ReadLine();
                    try{
                        d = int.Parse(ds);
                    }catch{
                        err2 = true;
                    }
                    if(err1 == false && err2 == false){
                        Fraction f = new Fraction(n, d);
                        Console.WriteLine(f.getFractionString());
                        Console.WriteLine(f.getFractionDecimal());
                    }else if(err1 == true && err2 == true){
                        Fraction f = new Fraction();
                        Console.WriteLine(f.getFractionString());
                        Console.WriteLine(f.getFractionDecimal());
                    }else{
                        Fraction f = new Fraction(1);
                        Console.WriteLine(f.getFractionString());
                        Console.WriteLine(f.getFractionDecimal());
                    }
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