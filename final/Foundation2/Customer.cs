using System;
using System.Runtime.InteropServices;

class Customer
{
    private string name;
    private Address address = new Address();
    public bool IsUS(){
        if(address.GetCountry() == "United States"){
            return true;
        }
        return false;
    }

    public void SetName(string n){
        name = n;
    }
    public void SetAddress(Address a){
        address = a;
    }
    public string GetName(){
        return name;
    }
    public string GetStreetAddress(){
        return address.GetStreetAddress();
    }
    public string GetCity(){
        return address.GetCity();
    }
    public int GetZip(){
        return address.GetZip();
    }
    public string GetCountry(){
        return address.GetCountry();
    }
    public string GetState(){
        return address.GetState();
    }
}