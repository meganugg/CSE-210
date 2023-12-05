using System;

class Comment
{
    private string name;
    private string text;
    public Comment(string n, string x){
        name = n;
        text = x;
    }
    public string GetName(){
        return name;
    }
    public string GetText(){
        return text;
    }
}