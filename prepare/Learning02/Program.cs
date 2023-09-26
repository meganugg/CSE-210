using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning02 World!");

        Job job1 = new Job();
        job1._title = "Aerospace Hardware Developer";
        job1._company = "Boeing";
        job1._startYear =  2025;
        job1._endYear = 2029;

        Job job2 = new Job();
        job2._title = "Quantum CPU Specialist";
        job2._company = "IBM";
        job2._startYear = 2029;
        job2._endYear = 2037;

        Job job3 = new Job();
        job3._title = "Manager of Operations";
        job3._company = "Quantum synthesizing solutions";
        job3._startYear = 2037;
        job3._endYear = 2041;

        Resume resume = new Resume();
        resume._name = "Tyler Strupp";
        resume._jobs.Add(job1);
        resume._jobs.Add(job2);
        resume._jobs.Add(job3);

        resume.display();
    }
}