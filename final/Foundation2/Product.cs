using System;
using System.Diagnostics.Contracts;

class Product
{
    private string name;
    private int ID;
    private double price;
    private int quantity;

    public Product(string n, int i, double p){
        name = n;
        ID = i;
        price = p;
    }

    public void SetQuantity(int q){
        quantity = q;
    }

    public string GetName(){
        return name;
    }
    public int GetID(){
        return ID;
    }
    public double GetPrice(){
        return price;
    }
    public int GetQuantity(){
        return quantity;
    }
}