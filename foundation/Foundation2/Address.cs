using System;
using System.Diagnostics.Metrics;

public class Address
{
    private string _street;
    private string _city;
    private string _state;
    private int _zipCode;
    private string _country;

    public Address(string street, string city, string state, int zipCode, string country)
    {
        _street = street; // Verificar se posso tirar this.
        _city = city;
        _state = state;
        _zipCode = zipCode;
        _country = country;
    }

    public bool IsAnUSAAddress()
    {
        return _country.ToLower() == "usa";
    }
    public string GetFullAddress()
    {
        return $"{_street}, {_city} - {_state}, {_zipCode} ({_country})";
    }
}