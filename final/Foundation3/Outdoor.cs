using System;

class Outdoor : Event
{
    private List<string> weather = new List<string>();
    public Outdoor(string t, string d, string dt, string tm, Address a) : base(t, d, dt, tm, a){
        weather.Add("Rainy");
        weather.Add("Sunny");
        weather.Add("Thunderstorms");
        weather.Add("Cloudy");
        weather.Add("Foggy");
        weather.Add("Partly Cloudy");
        weather.Add("Windy");
        weather.Add("Snow");
        weather.Add("Hail");
        weather.Add("Acid Rain");
        weather.Add("Humid");
        weather.Add("Tornado");
    }
    public override string FullDetails(){
        Random random = new Random();
        int i = random.Next(0, weather.Count());
        return $"Outdoor:\n{title}\n{date} - {time}\n{description}\nWeather forecast: {weather[i]}\n\n{address.GetAddress()}";
    }
    public override string ShortDescription(){
        return $"Outdoor:\n{title}\n{date}";
    }

}