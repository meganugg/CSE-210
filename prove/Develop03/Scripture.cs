using System;
using System.Net.Quic;

public class Scripture{
    private string _scripture;
    private string _reference;
    private string _quit;
    public Word w = new Word();

    public Scripture(){
        _scripture = "";
        _reference = "";
        _quit = "";
    }

    public void setReference(string r){
        _reference = r;
        _quit = "";
    }
    public void setScripture(string s){
        _scripture = s;
    }

    public bool memorize(){
        Console.Write(_reference + "  ");
        Console.WriteLine(_scripture);
        Console.WriteLine("Enter to continue or type 'quit' to exit.");
        Console.Write("> ");
        _quit = Console.ReadLine();
        Console.Clear();
        if(_quit != "quit"){
            _scripture = w.setScripture(_scripture);
        }
        if(w.empty() == true || _quit == "quit"){
            return true;
        }
        return false;
    }
}