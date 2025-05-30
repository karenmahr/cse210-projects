using System;

public class Customer
{
    private string _name;
    private Address _address;

    public Customer(string name, Address address)
    {
        _name = name;
        _address = address;
    }

    public string GetName()
    {
        return _name;
    }

    public Address GetAddress()
    {
        return _address;
    }

    private bool UnitedStates()
    {
        return _address.GetUnitedStates();
    }

    private int ShippingCost()
    {
        int shippingCost;
        if (UnitedStates() == true)
        {
            shippingCost = 5;
        }
        else
        {
            shippingCost = 35;
        }
        return shippingCost;
    }
    public int GetShippingCost()
    {
        return ShippingCost();
    }    
}