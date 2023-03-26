using System;

class Customer
{
    private string name;
    private Address address;

    public Customer(string name, Address address)
    {
        this.name = name;
        this.address = address;
    }

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public Address Address
    {
        get { return this.address; }
        set { this.address = value; }
    }

    public bool IsInUSA()
    {
        return this.address.IsInUSA();
    }
}
