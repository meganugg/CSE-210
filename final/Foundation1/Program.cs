using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation1 World!");
        Video v1 = new Video("I found Bigfoot", "Peter Caine", 551);
        Video v2 = new Video("Aerodynamics of a Cow", "PearWiggler", 823);
        Video v3 = new Video("Person situation is Crazy", "Charlie White", 739);
        Video v4 = new Video("I don't understand how this is possible", "DDoI", 318);

        v1.AddComment("nuggetbowl", "???");
        v1.AddComment("jared27", "No one in these comments has done any research on bigfoot. They wouldn't know what to look for or what's real.");
        v1.AddComment("bot", "Subscribe to my YouTube!!!");
        v1.AddComment("Kansass", "LMAOO this guys a clown");

        v2.AddComment("als907", "Very informative");
        v2.AddComment("-Bateman-", "do a pyramid of cows next");
        v2.AddComment("jkol", "awesome");

        v3.AddComment("yourmom", "What I don't understand is why anyone would even think to do this");
        v3.AddComment("6SpeedVibrator", "Charlie has no mercy");
        v3.AddComment("ItsAGiraffe", "Worse yet is that she doesn't think she's wrong. She won't change");
        v3.AddComment("mayonairstrike", "People these days...");

        v4.AddComment("kklosers", "1:21 lol");
        v4.AddComment("earthisflat", "Love the vids!!! keep up the good work!");
        v4.AddComment("earthisround", "We need long form content from this guy");
        v4.AddComment("terminat0r", "Did not think the second guy would send it that hard");

        Console.WriteLine(v1.GetVideo());
        Console.WriteLine(v2.GetVideo());
        Console.WriteLine(v3.GetVideo());
        Console.WriteLine(v4.GetVideo());

    }
}