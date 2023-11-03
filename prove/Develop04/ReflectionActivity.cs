using System;

class ReflectionActivity : Activity
{
    private List<string> secondaryPrompts = new List<string>();
    public ReflectionActivity(){
        prompts.Add("Think of a time you stood up for someone else");
        prompts.Add("Think of a time you did something really difficult");
        prompts.Add("Think of a time you helped someone in need");
        prompts.Add("Think of a time you did something truly selfless");

        secondaryPrompts.Add("Why was this experience meaningful to you?");
        secondaryPrompts.Add("Have you ever done anything like this before?");
        secondaryPrompts.Add("How did you get started?");
        secondaryPrompts.Add("How did you feel when it was complete?");
        secondaryPrompts.Add("What made this time different than other times when you were not as successful?");
        secondaryPrompts.Add("What is your favorite thing about this experience?");
        secondaryPrompts.Add("What could you learn from this experience that applies to other situations?");
        secondaryPrompts.Add("What did you learn about yourself through this experience?");
        secondaryPrompts.Add("How can you keep this experience in mind in the future?");
    }
    
    public void Run(){
        Console.WriteLine("Welcome to the reflection activity.\n");
        Console.WriteLine("This activity will help you reflect on times in your life when you have shown strength and resilience.");
        Console.WriteLine("This will help you recognize the power you have and how you can use it in other aspects of your life.\n");
        SetDuration();
        //round down
        durationRemainder = duration%8;
        if(durationRemainder < 3){
            duration -= durationRemainder;
        }
        //No reason for the "Get ready..." here
        Console.WriteLine("Consider the following prompt:\n");
        int randomIndex = random.Next(0, prompts.Count());
        Console.WriteLine($"--- {prompts[randomIndex]} ---\n");
        Console.WriteLine("When you have something in mind, press enter to continue");
        Console.ReadLine();
        Console.WriteLine("Ponder each of the following questions as they relate to your experience.");
        Console.Write("[------] ");
        //Countdown to start
        for(int j = 0; j < 5; j++){
            Console.Write("\b\b\b\b-] ");
            Thread.Sleep(1000);
        }
        Console.Clear();

        endDate = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < endDate){
            randomIndex = random.Next(0, secondaryPrompts.Count());
            Console.Write(secondaryPrompts[randomIndex]);
            Pause(32);
            Console.WriteLine();
            secondaryPrompts.RemoveAt(randomIndex);
            //in case entered time is over the amount of total time this list of questions are displayed
            if(secondaryPrompts.Count() == 0){
                secondaryPrompts.Add("Why was this experience meaningful to you?");
                secondaryPrompts.Add("Have you ever done anything like this before?");
                secondaryPrompts.Add("How did you get started?");
                secondaryPrompts.Add("How did you feel when it was complete?");
                secondaryPrompts.Add("What made this time different than other times when you were not as successful?");
                secondaryPrompts.Add("What is your favorite thing about this experience?");
                secondaryPrompts.Add("What could you learn from this experience that applies to other situations?");
                secondaryPrompts.Add("What did you learn about yourself through this experience?");
                secondaryPrompts.Add("How can you keep this experience in mind in the future?");
            }
        }
        Console.WriteLine(finishingMessage);
        Pause(12);
        Console.Clear();
    }

}