using System;

class ListingActivity : Activity
{
    private List<string> responses = new List<string>();
    private string line;
    public ListingActivity(){
        prompts.Add("Who are people you appreciate?");
        prompts.Add("What are personal strengths of yours?");
        prompts.Add("Who are people that you have helped this week?");
        prompts.Add("When have you felt the Holy Ghost this month?");
        prompts.Add("Who are some of your personal heroes?");
        responses.Clear();
    }

    public void Run(){
        Console.WriteLine("Welcome to the listing activity.\n");
        Console.WriteLine("This activity will help you reflect on good things in your life by having you list as many things as you can in a certain area.\n");
        SetDuration();
        Console.WriteLine("List as many respones as you can about the following prompt:\n");
        int randomIndex = random.Next(0, prompts.Count());
        Console.WriteLine($"--- {prompts[randomIndex]} ---\n");
        Console.Write("[------] ");
        //Countdown to start
        for(int j = 0; j < 5; j++){
            Console.Write("\b\b\b\b-] ");
            Thread.Sleep(1000);
        }
        Console.Clear();

        endDate = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < endDate){
            Console.Write("> ");
            line = Console.ReadLine();
            //don't add accidental blank responses
            if(line != ""){
                responses.Add(line);
            }
        }
        Console.WriteLine($"\nYou listed {responses.Count()} items!");
        Console.WriteLine(finishingMessage);
        Pause(12);
        Console.Clear();
    }
}