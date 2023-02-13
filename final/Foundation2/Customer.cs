using System;

public class Customer
{
    private string _customername;

    private Address _address;

    public Customer(string customername, Address address)
    {
        _customername = customername;
        _address = address;
    }
    public string GetCustomername()
    {
        return _customername;
    }
    public void SetCustomername(string customername)
    {
        _customername = customername;
    }

    public Address GetAddress()
    {
        return _address;
    }
    public void SetAddress(Address address)
    {
        _address = address;
    }
    public bool LivesInUSA()
    {
        return _address.IsInUSA();
    }
 
}