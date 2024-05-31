using System;
public class Customer
{
    private string _customerName;
    private Address _adress;
    public Customer(string customerName, string streetAddress, string city, string stateOrProvince, string country)
    {
        _customerName = customerName;
        _adress = new Address(streetAddress, city, stateOrProvince, country);
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public bool LivingInUsa()
    {
        return _adress.LivingInUsa();
    }
    public string GetFullAddress()
    {
        return $"{_adress.GetFullAdress()}";
    }
}
