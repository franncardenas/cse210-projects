using System;

class Program
{
    static void Main(string[] args)
    {
        //Create products 1
        Product product1 = new Product("Sweater", "AH4675", 15, 1);
        Product product2 = new Product("Jean", "CC7821", 24, 2);
        Product product3 = new Product("T-shirt", "FC2853", 8, 4);

        //Create Customer 1
        Address address1 = new Address("Calle Rivadavia 324", "La Plata", "Buenos Aires", "Argentina");
        Customer customer1 = new Customer("Nicolas Alvez", address1);  

        //Create Order 1
        Order order1 = new Order(customer1);
        order1.AddProduct(product1);
        order1.AddProduct(product2);
        order1.AddProduct(product3);

        //Create product 2 
        Product product4 = new Product("Jacket", "KR4728", 26, 1);
        Product product5 = new Product("Socks", "OL1006", 3, 6);
        Product product6 = new Product("Sneakers", "ZW6345", 26, 1);

        //Create Customer 2 
        Address address2 = new Address("241 Main St", "Sandy", "Utah", "USA");
        Customer customer2 = new Customer("Alvin Frink", address2);

        //Create Order 2 
        Order order2 = new Order(customer2);
        order2.AddProduct(product4);
        order2.AddProduct(product5);
        order2.AddProduct(product6);

        //Methodes order 1 
        Console.WriteLine("First Order:");
        order1.PackingLabel();
        order1.ShippingLabel();
        double totalcost1 = order1.CalculateTotalCost();
        Console.WriteLine($"Total purchase price: ${totalcost1}");
        Console.WriteLine("");

        //Methodes order 2
        Console.WriteLine("Second Order:");
        order2.PackingLabel();
        order2.ShippingLabel();
        double totalcost2 = order2.CalculateTotalCost();
        Console.WriteLine($"Total purchase price: ${totalcost1}");
    }
}