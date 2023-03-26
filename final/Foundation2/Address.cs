using System;

class Address
{
    private string streetAddress;
    private string city;
    private string stateProvince;
    private string country;

    public Address(string streetAddress, string city, string stateProvince, string country)
    {
        this.streetAddress = streetAddress;
        this.city = city;
        this.stateProvince = stateProvince;
        this.country = country;
    }

    public bool IsInUSA()
    {
        return this.country == "USA";
    }

    public string GetFullAddress()
    {
        return $"{this.streetAddress}\n{this.city}, {this.stateProvince}\n{this.country}";
    }
}
