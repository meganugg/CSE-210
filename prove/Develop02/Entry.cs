using System;
using System.IO.Compression;

class Entry
{
public String date;
public int prompt;
public String entry;
String[] prompts =  {"Who was the most interesting person I interacted with today?", 
                    "What was the best part of my day?",
                    "How did I see the hand of the Lord in my life today?",
                    "What was the strongest emotion I felt today?",
                    "If I had one thing I could do over today, what would it be?",
                    "What was the most interesting thing that happened to me today?",
                    "Have I served anyone today? (If yes, how; if no, why not?)",
                    "What did I accomplish today?",
                    "What did I learn today?",
                    "What's a problem you're facing and how are you going to solve it?",
                    "If I could have served more people today, how would I have done it?"};
public void displayPrompt(){
    Console.WriteLine($"{date} - {prompts[prompt]}");
}

public void displayEntry(){
    Console.WriteLine($"{date} - {prompts[prompt]}");
    Console.WriteLine(entry);
}
}