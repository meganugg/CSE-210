using System;

public class Job
{
    public String _title;
    public String _company;
    public int _startYear;
    public int _endYear;

    public void display(){
        Console.WriteLine($"{_title} ({_company}) {_startYear}-{_endYear}");
    }
}