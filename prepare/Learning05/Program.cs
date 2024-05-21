using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("azul", 2);
        //Console.WriteLine(square.GetColor());
        //Console.WriteLine(square.GetArea());

        Rectangle rectangle = new Rectangle("rojo", 2, 4);
        //Console.WriteLine(rectangle.GetColor());
        //Console.WriteLine(rectangle.GetArea());

        Circle circle = new Circle("verde", 3);
        //Console.WriteLine(circle.GetColor());
        //Console.WriteLine(circle.GetArea());

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach(Shape i in shapes)
        {
        string color = i.GetColor();
        double area = i.GetArea();
        Console.WriteLine($"The color of the shape is {color} and the area is {area}");
        }






        //shapes.Add(Rectangle("Marron", 4,2 ));
        



        // employees.add(new Employee());
        // employees.add(new HourlyEmployee());


        // foreach(Employee employee in employees)
        // {
        // float pay = employee.CalculatePay();
        // Console.WriteLine(pay);
        // }
        }
}