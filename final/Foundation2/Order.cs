using System;

class Order
{
    Customer customer = new Customer();
    List<Product> products = new List<Product>();

    public Order(Customer c){
        customer = c;
    }
    public void AddProduct(Product p, int q){
        p.SetQuantity(q);
        products.Add(p);
    }
    public void PrintPackingLabel(){
        Console.WriteLine("{0,-20} {1,5}\n", "Item", "ID");
        for(int i = 0; i < products.Count(); i++){
            Console.WriteLine("{0,-20} {1, 5}", products[i].GetName(), products[i].GetID());
        }
    }
    public void PrintShippingLabel(){
        Console.WriteLine($"{customer.GetName()}");
        Console.WriteLine($"{customer.GetStreetAddress()}");
        Console.WriteLine($"{customer.GetCity()}, {customer.GetState()} {customer.GetZip()}");
        Console.WriteLine($"{customer.GetCountry()}");
    }
    public double GetTotal(){
        double total = 0;
        for(int i = 0; i < products.Count(); i++){
            total += products[i].GetPrice() * products[i].GetQuantity();
        }
        if(customer.IsUS() == true){
            total += 5;
        }else{
            total += 35;
        }
        return Math.Round(total, 2);
    }
}