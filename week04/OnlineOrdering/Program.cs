using System;

class Program
{
    static void Main(string[] args)
    {
        Address a1 = new Address("Avenida Libertador 1509", "Vicente Lopez", "Buenos Aires", "Argentina");
        Customer c1 = new Customer("Agustina Sanchez", a1);
        List<Product> products1 = new List<Product>
        {
            new Product("Cheese", 101, 3, 2),
            new Product("Bread", 102, 2, 1),
            new Product("Eggs", 103, 5, 1)
        };
        Order order1 = new Order(c1, products1);  

        Address a2 = new Address("123 Main Street", "Provo", "UT", "United States");
        Customer c2 = new Customer("Lindsey Smith", a2);
        List<Product> products2 = new List<Product>
        {
            new Product("Tomato", 201, 4, 1),
            new Product("Cookies", 202, 6, 2)
        };
        Order order2 = new Order(c2, products2);

        Console.WriteLine("Order for: " + c1.GetName());
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order1.GetTotalCostOrder());

        Console.WriteLine("");
        Console.WriteLine("Order for: " + c2.GetName());
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Cost: $" + order2.GetTotalCostOrder());                                
    }
}