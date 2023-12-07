using System;

class Reception : Event
{
    public Reception(string t, string d, string dt, string tm, Address a, string e) : base(t, d, dt, tm, a, e){}
    public override string FullDetails(){
        return $"Reception:\n{title}\n{date} - {time}\n{description}\nRSVP: {email}\n\n{address.GetAddress()}";
    }
    public override string ShortDescription(){
        return $"Reception:\n{title}\n{date}";
    }

}