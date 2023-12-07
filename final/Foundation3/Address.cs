using System;

class Address
{
    private string city;
    private string state;
    private int zip;
    private string streetAddress;
    public Address(){}
    public Address(string c, string s, int z, string sta){
        city = c;
        state = s;
        zip = z;
        streetAddress = sta;
    }
    public string GetAddress(){
        return $"{city}, {state} {zip}\n{streetAddress}";
    }
}