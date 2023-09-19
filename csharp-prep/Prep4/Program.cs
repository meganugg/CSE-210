using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep4 World!");
        Console.WriteLine("Enter a list of numbers, type 0 when finished");
        int entry = -1;
        List<int> numbers = new List<int>();
        while(entry != 0){
            Console.Write("Entry: ");
            String entry_string = Console.ReadLine();
            entry = int.Parse(entry_string);
            numbers.Add(entry);
        }
        int total = 0;
        int largest = 0;
        for(int i = 0; i < numbers.Count; i++){
             total += numbers[i];
             if(numbers[i] > largest){
                largest = numbers[i];
             }
        }
        float avg = ((float)total)/(numbers.Count-1);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}