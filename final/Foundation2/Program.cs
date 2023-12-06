using System;
using System.Security;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Foundation2 World!");
        Customer c1 = new Customer();
        Address a1 = new Address("Rexburg", "ID", 83440, "United States", "35 W 2nd N Apt 12");
        c1.SetName("Ivan Pavlov");
        c1.SetAddress(a1);
        Customer c2 = new Customer();
        Address a2 = new Address("Naperville", "IL", 60540, "United States", "1008 Lakewood Cir");
        c2.SetName("Fredrick Gauss");
        c2.SetAddress(a2);
        Customer c3 = new Customer();
        Address a3 = new Address("Rione Biccari", "FG", 71122, "Italia", "Via Lorenzo Perosi, 7");
        c3.SetName("Leonardo DaVinci");
        c3.SetAddress(a3);
        Product blender = new Product("Blender", 580365, 51.22);
        Product socks = new Product("Socks", 980324, 1.99);
        Product cheese = new Product("Cheese", 554221, 5.99);
        Product umbrella = new Product("Umbrella", 733257, 10.50);
        Product kite = new Product("Kite", 965163, 8.33);
        Product hat = new Product("Hat", 452000, 5.89);
        Product laptop = new Product("Laptop", 895203, 199.99);
        Product paint = new Product("Paint Set", 862112, 45.00);

        Order o1 = new Order(c1);
        o1.AddProduct(blender, 1);
        o1.AddProduct(umbrella, 2);
        o1.AddProduct(hat, 1);
        Order o2 = new Order(c2);
        o2.AddProduct(socks, 5);
        o2.AddProduct(kite, 1);
        o2.AddProduct(laptop, 1);
        Order o3 = new Order(c3);
        o3.AddProduct(cheese, 7);
        o3.AddProduct(paint, 1);
        o3.AddProduct(laptop, 1);
        o3.AddProduct(socks, 10);

        List<Order> orders = new List<Order>();
        orders.Add(o1);
        orders.Add(o2);
        orders.Add(o3);

        foreach(Order o in orders){
            o.PrintPackingLabel();
            Console.WriteLine($"Total: ${o.GetTotal()}\n");
            o.PrintShippingLabel();
            Console.WriteLine("\n--------------------------");
        }
    }
}