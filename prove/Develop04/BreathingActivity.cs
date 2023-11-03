using System;

class BreathingActivity : Activity
{
    public void Run(){
        Console.WriteLine("Welcome to the breathing activity.\n");
        Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.\n");
        while(duration < 10){
            SetDuration();
            if(duration < 10){
                Console.WriteLine("Your breathing exercise should be at least 10 seconds.");
            }
        }
        //round down if duration is 3 or less seconds above a 10s increment
        durationRemainder = duration%10;
        if(durationRemainder < 4){
            duration -= durationRemainder;
        }
        Console.WriteLine("(In 5, out 5)");
        Console.WriteLine("Get ready...");
        Pause(12);

        endDate = DateTime.Now.AddSeconds(duration);
        while(DateTime.Now < endDate){
            //in
            Console.Write("\nBreathe in... []");
            for(int i = 0; i < 5; i++){
                Console.Write("\b-]");
                Thread.Sleep(1000);
            }
            Console.Write("\nBreathe out... [------] ");
            for(int i = 0; i < 5; i++){
                Console.Write("\b\b\b\b-] ");
                Thread.Sleep(1000);
            }
            Console.WriteLine();
        }
        Console.WriteLine(finishingMessage);
        Pause(12);
        Console.Clear();
    }

}