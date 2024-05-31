using System;
public class Order
{
    private List<Product> _products = new List<Product>();
    private Customer _customer;
    
    public Order(string costumerName, string streetAdress, string city, string stateOrProvince, string country)
    {
        _customer = new Customer(costumerName, streetAdress, city, stateOrProvince, country);
    }

    public void AddProduct(string productName, string productId, double price, int quantity)
    {
        Product newProduct = new Product(productName, productId, price, quantity);
        _products.Add(newProduct);
    }

    public void CalculateTotalCost()
    {
        double totalCost = 0.00;
        foreach (Product product in _products)
        {
            totalCost += product.CalculateCost();
        }

        Console.WriteLine($"The total products cost is {totalCost}");
        if(_customer.LivingInUsa()==true)
        {
            Console.WriteLine($"the Shipping cost within the USA is $5.00\nThe total cost is {totalCost+5}\n\n");
        }
        else{
            Console.WriteLine($"The Shipping cost outside the USA is $35.00\nThe total cost is {totalCost+35}\n\n");
        }
    }
    public void CreatePackingLabel()
    {
        Console.WriteLine("---Packing Label---");
        foreach(Product product in _products)
        {   
            Console.WriteLine($"Product: {product.GetProductName()}");
            Console.WriteLine($"Id: {product.GetProductId()}");
            Console.WriteLine($"Quantity: {product.GetQuantity()}\n");
        }
    }
    public void CreateShippingLabel()
    {
        Console.WriteLine("---Shipping Label---");
        Console.WriteLine($"Customer: {_customer.GetCustomerName()}");
        Console.WriteLine($"Adress: {_customer.GetFullAdress()}\n");
    }
}