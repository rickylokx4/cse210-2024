using System;
public class Address
{
    private string _streetAdress;
    private string _city;
    private string _stateOrProvince;
    private string _country;

    // public Address(string streetAdress, string city, string stateOrProvince, string country)
    public Address(string streetAdress, string city, string stateOrProvince,string country)
    {
        _streetAdress = streetAdress;
        _city = city;
        _stateOrProvince = stateOrProvince;
        _country = country;
    }

    public string GetAddress()
    {
        return $"{_streetAdress} {_city} {_stateOrProvince} {_country}";
    }

    // public Address(string streetAdress, string city, string stateOrProvince, string country)
    // {
    //     _streetAdress = streetAdress;
    //     _city = city;
    //     _stateOrProvince = stateOrProvince;
    //     _country = country.ToUpper();
    // }


    
}