using System;

public class Address
{
    private string _streetAddress;
    private string _city;
    private string _state;
    private string _country;

    public Address(string streetAddress, string city, string state, string country)
    {
        _streetAddress = streetAddress;
        _city = city;
        _state = state;
        _country = country;
    }

    private bool UnitedStates()
    {
        if (_country == "USA")
        {
            return true;
        }
        return false;
    }

    public bool GetUnitedStates()
    {
        return UnitedStates();
    }

    public string GetCountry()
    {
        return _country;
    }

    private string CompleteAddress()
    {
        return $"{_streetAddress}, {_city}, {_state}, {_country}";
    }

    public string GetCompleteAddress()
    {
        return CompleteAddress();
    }    
}
