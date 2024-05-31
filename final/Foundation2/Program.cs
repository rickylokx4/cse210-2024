using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order("Fernado Salazar", "1965 Darvany Dr", "Dallas", "Texas", "Usa");
        order1.AddProduct("Asus Laptop", "MZE1245", 1499.99, 1);
        order1.AddProduct("Mouse Logitech", "G30", 49.99, 2);
        order1.AddProduct("Headset Logitech", "G432", 55.99, 2);
        order1.CreatePackingLabel();
        order1.CreateShippingLabel();
        order1.CalculateTotalCost();

        Order order2 = new Order("Benjamin Salazar", "Via Giuseppe Tartini 12", "Torino", "Torino", "Italy");
        order2.AddProduct("Razer Gaming Chair", "T01L1140", 399.99, 1);
        order2.AddProduct("Mousepad Razer", "MSP10010", 10.00, 2);
        order2.AddProduct("WebCam Logitech", "WB1241", 50.00, 2);
        order2.CreatePackingLabel();
        order2.CreateShippingLabel();
        order2.CalculateTotalCost();

    }
}