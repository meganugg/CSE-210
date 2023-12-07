using System;

class Lecture : Event
{
    public Lecture(string t, string d, string dt, string tm, Address a, string s, string c) : base(t, d, dt, tm, a, s, c){}
    public override string FullDetails(){
        return $"Lecture:\n{title} ({speaker})\n{date} - {time}\n{description}\nSeating {capacity}\n\n{address.GetAddress()}";
    }
    public override string ShortDescription(){
        return $"Lecture:\n{title}\n{date}";
    }
}