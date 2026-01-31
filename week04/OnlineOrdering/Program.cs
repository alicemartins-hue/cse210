using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the OnlineOrdering Project.");

        Address address1 = new Address(
            "street",
            "city 1",
            "state 1",
            "Usa"
        );


        Customer customer1 = new Customer(
            "Customer1", address1
        );

        Order order1 = new Order(customer1);

        Product p1 = new Product("Pencil", 001, 0.25, 58);
        Product p2 = new Product("Notebook", 547, 11.25, 12);
        Product p3 = new Product("Erase", 888, 2, 700);

        order1.AddProduct(p1);
        order1.AddProduct(p2);
        order1.AddProduct(p3);


        Address address2 = new Address(
            "street else",
            "city 2",
            "state 2",
            "BRAZIL"
        );

        Customer customer2 = new Customer(
            "Customer2", address2
        );

        Order order2 = new Order(customer2);

        Product w1 = new Product("Ring", 1, 1300, 1);
        Product w2 = new Product("Mercurio", 80, 11.25, 12);
        Product w3 = new Product("Book", 115, 12.0, 2);

        order2.AddProduct(w1);
        order2.AddProduct(w2);
        order2.AddProduct(w3);

        Console.WriteLine($"{order1.GetShippingLabel()}");
        Console.WriteLine($"{order1.PackingLabel()}");
        Console.WriteLine($"The total Cost: ${order1.CalculateTotalCost()} dollares\n");

        Console.WriteLine($"{order2.GetShippingLabel()}");
        Console.WriteLine($"\n{order2.PackingLabel()}");
        Console.WriteLine($"The total Cost: ${order2.CalculateTotalCost()} dollares\n");

    }
}