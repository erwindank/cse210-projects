using System;

class Product
{
    private string name;
    private int productId;
    private double price;
    private int quantity;

    public Product(string name, int productId, double price, int quantity)
    {
        this.name = name;
        this.productId = productId;
        this.price = price;
        this.quantity = quantity;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int ProductId
    {
        get { return this.productId; }
        set { this.productId = value; }
    }

    public double Price
    {
        get { return this.price; }
        set { this.price = value; }
    }

    public int Quantity
    {
        get { return this.quantity; }
        set { this.quantity = value; }
    }

    public double TotalPrice()
    {
        return this.price * this.quantity;
    }
}
