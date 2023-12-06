using System;
using System.Runtime.InteropServices;

class Address
{
    private string streetAddress;
    private string state;
    private string country;
    private string city;
    private int zip;

    public Address(){
        city = "";
        state = "";
        zip = 0;
        country = "";
        streetAddress = "";
    }
    public Address(string c, string s, int z, string cr, string sa){
        city = c;
        state = s;
        zip = z;
        country = cr;
        streetAddress = sa;
    }

    public string GetCountry(){
        return country;
    }
    public int GetZip(){
        return zip;
    }
    public string GetStreetAddress(){
        return streetAddress;
    }
    public string GetState(){
        return state;
    }
    public string GetCity(){
        return city;
    }
}