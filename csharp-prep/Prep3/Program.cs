using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 101);
        int guess = -50;
        int guess_count = 0;
        Console.WriteLine("Guess the number (1 - 100)");
        while(guess != magic_number){
            guess_count++;
            String guess_string = Console.ReadLine();
            guess = int.Parse(guess_string);
            if(guess > magic_number){
                Console.WriteLine("Too high");
            }
            if(guess < magic_number){
                Console.WriteLine("Too low");
            }
        }
        Console.WriteLine($"You guessed the number! ({magic_number})");
        Console.WriteLine($"It took you {guess_count} guesses");
    }
}