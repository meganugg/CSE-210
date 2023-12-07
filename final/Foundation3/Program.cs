using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation3 World!");
        Address al = new Address("Cambridge", "MA", 02138, "1279 Massachusetts Ave");
        Address ar = new Address("San Francisco", "CA", 94107, "601 19th St");
        Address ao = new Address("Florence", "OR", 97439, "N Jetty Rd");

        Lecture l = new Lecture("The Effects of Cosmic Radiation on Microprocessors", "A discussion on the various properties and implications of cosmic radiation and how it affects computers in space and on earth", "4/11/24", "6:00pm", al, "Stuart M. Shieber", "850");
        Reception r = new Reception("Ashton and Macy", "Join us to celebrate Macy and Ashton's marriage!", "12/12/24", "7:00pm", ar, "macyst@gmail.com");
        Outdoor o = new Outdoor("Brown Family Reunion", "We miss you! Come say hi! Snacks and drinks provided!", "5/5/24", "10:00am", ao);

        List<Event> es = new List<Event>();
        es.Add(l);
        es.Add(r);
        es.Add(o);

        foreach(Event e in es){
            Console.WriteLine("\nStandard details:");
            Console.WriteLine(e.StandardDetails());
            Console.WriteLine("\nFull Details:");
            Console.WriteLine(e.FullDetails());
            Console.WriteLine("\nShort Description:");
            Console.WriteLine(e.ShortDescription());
        }
    }
}