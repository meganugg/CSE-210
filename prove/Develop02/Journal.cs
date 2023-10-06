using System;
using System.IO;

class Journal
{
public List<Entry> entries = new List<Entry>();
public String filename;
String fullEntry = "";
    
    public void display(){
        if(entries.Count == 0 && fullEntry == ""){
            Console.WriteLine("No entries to display. Please create a new entry or load a file of journals.");
        }
        else if(entries.Count == 0){
            Console.WriteLine(fullEntry);
        }
        else{
            Console.Write(fullEntry);
            for(int i = 0; i < entries.Count; i++){
                Console.WriteLine(entries[i].displayEntry());
            }
        }
    }

    public void save(){
        using (StreamWriter outputFile = new StreamWriter(filename)){
            for(int i = 0; i < entries.Count; i++){
                outputFile.WriteLine(entries[i].displayEntry());
            }
        }
    }

    public void load(){
        String[] lines = System.IO.File.ReadAllLines(filename);
        fullEntry = "";
        foreach(String line in lines){
            fullEntry += $"{line}\n";
        }
    }
}