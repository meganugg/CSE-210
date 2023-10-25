using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning04 World!\n");
        MathAssignment mhw = new MathAssignment();
        mhw.setProperties("Tyler Strupp", "Linear Algebra");
        mhw.setHomeWorkList("4.1", "1-5, 8-10, 22-25");
        Console.WriteLine(mhw.getSummary());
        Console.WriteLine(mhw.getHomeWorkList());
        Console.WriteLine();

        WritingAssignment whw = new WritingAssignment();
        whw.setProperties("Tyler Strupp", "US History");
        whw.setTitle("Candidates of Kennedy's assassination");
        Console.WriteLine(whw.getSummary());
        Console.WriteLine(whw.getWritingInformation());
    }
}