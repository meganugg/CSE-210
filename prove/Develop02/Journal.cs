using System;

class Journal
{
public List<Entry> entries = new List<Entry>();
    
    public void display(){
        if(entries.Count == 0){
            Console.WriteLine("No entries to display. Please create a new entry or load a file of journals.");
        }
        else{
            for(int i = 0; i < entries.Count; i++){
            entries[i].displayEntry();
            Console.WriteLine("");
            }
        }
    }
}