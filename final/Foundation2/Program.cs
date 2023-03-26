using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("***** PRODUCT ORDERING SYSTEM *****");
        Console.WriteLine("-- The following orders are in place --");
        // Creating products
        Product product1 = new Product("Black Toner Cartridge", 00601734, 257.00, 1);
        Product product2 = new Product("Cyan Toner Cartridge", 00601735, 514.00, 1);
        Product product3 = new Product("Magenta Toner Cartridge", 00601736, 514.00, 1);
        Product product4 = new Product("Yellow Toner Cartridge", 00601737, 514.00, 1);
        Product product5 = new Product("Waste Bottle Container", 00812990, 64.95, 1);
        Product product6 = new Product("Fuser", 00813102, 565.00, 1);

        // Creating customers
        Address customerAddress1 = new Address("6701 67th Ln N", "Pinellas Park", "FL", "USA");
        Customer customer1 = new Customer("John Packer", customerAddress1);

        Address customerAddress2 = new Address("414 North Beverly", "Shoshone", "ID", "USA");
        Customer customer2 = new Customer("Larry Jones", customerAddress2);

        Address customerAddress3 = new Address("1440 52 St NE", "Calgary", "AB", "Canada");
        Customer customer3 = new Customer("Martha Juarez", customerAddress3);

        Address customerAddress4 = new Address("3090 Cross Ln", "Idaho Falls", "ID", "USA");
        Customer customer4 = new Customer("Jane Carrey", customerAddress4);

        // Getting orders created
        List<Product> order1Products = new List<Product> {product1, product2, product3, product4};
        Order order1 = new Order(customer1, order1Products);

        List<Product> order2Products = new List<Product> {product1, product5};
        Order order2 = new Order(customer2, order2Products);

        List<Product> order3Products = new List<Product> {product1, product2};
        Order order3 = new Order(customer3, order3Products);

        List<Product> order4Products = new List<Product> {product3, product4, product6};
        Order order4 = new Order(customer4, order4Products);

        // Display the packing, and shipping label, and total price of the orders
        Console.WriteLine("Order 1");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order1.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order1.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order1.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 2");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order2.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order2.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order2.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 3");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order3.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order3.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order3.GetTotalPrice());

        Console.WriteLine();

        Console.WriteLine("Order 4");
        Console.WriteLine("Packing Label:");
        Console.WriteLine(order4.GetPackingLabel());
        Console.WriteLine("Shipping Label:");
        Console.WriteLine(order4.GetShippingLabel());
        Console.WriteLine("Total Price: $" + order4.GetTotalPrice());
    }
}
