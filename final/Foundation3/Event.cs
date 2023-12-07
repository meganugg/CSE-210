using System;

abstract class Event
{
    protected string title;
    protected string description;
    protected string date;
    protected string time;
    protected Address address = new Address();
    protected string email;
    protected string speaker;
    protected string capacity;
    protected Event(string t, string d, string dt, string tm, Address a){
        title = t;
        description = d;
        date = dt;
        time = tm;
        address = a;
    }
    protected Event(string t, string d, string dt, string tm, Address a, string e){
        title = t;
        description = d;
        date = dt;
        time = tm;
        address = a;
        email = e;
    }
    protected Event(string t, string d, string dt, string tm, Address a, string s, string c){
        title = t;
        description = d;
        date = dt;
        time = tm;
        address = a;
        speaker = s;
        capacity = c;
    }

    public string StandardDetails(){
        return $"{title}\n{date} - {time}\n{description}\n\n{address.GetAddress()}";
    }
    public abstract string FullDetails();
    public abstract string ShortDescription();
}