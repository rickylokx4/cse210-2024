using System;
public class Customer
{
    private string _customerName;
    private Adress _adress;
    public Customer(string customerName, string streetAdress, string city, string stateOrProvince, string country)
    {
        _customerName = customerName;
        _adress = new Adress(streetAdress, city, stateOrProvince, country);
    }
    public string GetCustomerName()
    {
        return _customerName;
    }
    public bool LivingInUsa()
    {
        return _adress.LivingInUsa();
    }
    public string GetFullAdress()
    {
        return $"{_adress.GetFullAdress()}";
    }
}
