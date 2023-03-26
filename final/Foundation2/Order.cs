using System;
using System.Collections.Generic;

class Order
{
    private List<Product> products;
    private Customer customer;

    public Order(Customer customer, List<Product> products)
    {
        this.customer = customer;
        this.products = products;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in products)
        {
            totalPrice += product.Price * product.Quantity;
        }

        if (customer.IsInUSA())
        {
            totalPrice += 5.0;
        }
        else
        {
            totalPrice += 35.0;
        }

        return totalPrice;
    }

    public string GetPackingLabel()
    {
        string packingLabel = "";
        foreach (Product product in products)
        {
            packingLabel += product.Name + " (" + product.ProductId + ")\n";
        }

        return packingLabel;
    }

    public string GetShippingLabel()
    {
        string shippingLabel = customer.Name + "\n" + customer.Address.GetFullAddress();
        return shippingLabel;
    }
}
