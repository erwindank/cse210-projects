class Address {
    private string _street;
    private string _city;
    private string _state;
    private string _zipCode;

    public Address(string street, string city, string state, string zipCode) {
        this._street = street;
        this._city = city;
        this._state = state;
        this._zipCode = zipCode;
    }

    public override string ToString() {
        return String.Format("{0} {1}, {2} {3}", _street, _city, _state, _zipCode);
    }
}