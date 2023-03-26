using System;

class Program
{
    static void Main(string[] args)
    {
        // Create some products
        Product p1 = new Product("Toothbrush", "1234", 2.99, 2);
        Product p2 = new Product("Shampoo", "5678", 5.99, 1);

        // Create a customer
        Address a1 = new Address("123 Main St", "Anytown", "NY", "USA");
        Customer c1 = new Customer("John Smith", a1);

        // Create an order
        Order o1 = new Order(c1);
        o1.AddProduct(p1);
        o1.AddProduct(p2);

        // Calculate and display the total price of the order
        Console.WriteLine("Total price of order 1: $" + o1.TotalPrice());

        // Display the packing label for the order
        Console.WriteLine("Packing label for order 1:");
        Console.WriteLine(o1.PackingLabel());

        // Display the shipping label for the order
        Console.WriteLine("Shipping label for order 1:");
        Console.WriteLine(o1.ShippingLabel());

        // Create another customer
        Address a2 = new Address("456 Broadway", "Anytown", "ON", "Canada");
        Customer c2 = new Customer("Jane Doe", a2);

        // Create another order
        Order o2 = new Order(c2);
        o2.AddProduct(p2);

        // Calculate and display the total price of the order
        Console.WriteLine("Total price of order 2: $" + o2.TotalPrice());

        // Display the packing label for the order
        Console.WriteLine("Packing label for order 2:");
        Console.WriteLine(o2.PackingLabel());

        // Display the shipping label for the order
        Console.WriteLine("Shipping label for order 2:");
        Console.WriteLine(o2.ShippingLabel());
    }
}

class Product
{
    private string name;
    private string id;
    private double price;
    private int quantity;

    public Product(string name, string id, double price, int quantity)
    {
        this.name = name;
        this.id = id;
        this.price = price;
        this.quantity = quantity;
    }

    public double Price()
    {
        return price * quantity;
    }

    public string Name()
    {
        return name;
    }

    public string Id()
    {
        return id;
    }
}

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public bool IsInUSA()
    {
        return address.IsInUSA();
    }

    public string Name()
    {
        return name;
    }

    public Address Address()
    {
        return address;
    }
}

class Address
{
    private string street;
    private string city;
    private string state;
    private string country;

    public Address(string street, string city, string state, string country)
    {
        this.street = street;
        this.city = city;
        this.state = state;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return country.Equals("USA");
    }

    public string Street()
    {
        return street;
    }

    public string City()
    {
        return city;
    }

    public string State()
    {
        return state;
    }

    public string Country()
    {
        return country;
    }

    public string ToString()
    {
        return street + "\n" + city + ", " + state + " " + country;
    }
}

