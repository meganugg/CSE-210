using System;
using Microsoft.VisualBasic;

class Activity
{
    private bool escape;
    private string input;
    private List<string> spinner = new List<string>();
    protected List<string> prompts = new List<string>();
    protected Random random = new Random();
    //figured there was no reason for a "startingMessage" variable because while they all have a starting message, they
    //would just get initialized as a different message for each activity anyway. Why not just print them without a variable
    protected string finishingMessage;
    protected int durationRemainder;
    protected int duration;
    protected DateTime endDate;
    

    public Activity(){
        spinner.Add("|");
        spinner.Add("\\");
        spinner.Add("-");
        spinner.Add("/");
        duration = 0;
        finishingMessage = "Great job!";
    }

    protected void SetDuration(){
        escape = false;
        while(escape == false){
            Console.WriteLine("How long - in seconds - would you like for your session?");
            Console.Write("> ");
            input = Console.ReadLine();
            try{
                duration = int.Parse(input);
            }catch{
                Console.WriteLine("Enter a valid integer");
            }finally{
                escape = true;
            }
        }
        
        Console.Clear();
    }

    protected void Pause(int n){
        int index = 0;
        for(int i = 0; i < n; i++){
            Console.Write(spinner[index]);
            Thread.Sleep(250);
            Console.Write("\b \b");
            index++;
            if(index > 3){
                index = 0;
            }
        }
    }
}