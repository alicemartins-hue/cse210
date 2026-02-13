using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Shapes Project.");

        Console.WriteLine("Testing the program");

        Square square = new Square("white", 25);
        Console.WriteLine(square.GetArea());
        Console.WriteLine(square.GetColor());

        Console.WriteLine("");

        Rectangle rectangle = new Rectangle("blue", 2, 2.4);
        Console.WriteLine(rectangle.GetArea());
        Console.WriteLine(rectangle.GetColor());

        Console.WriteLine("");

        Circle circle = new Circle("yellow", 3.1);
        Console.WriteLine(circle.GetArea());
        Console.WriteLine(circle.GetColor());

        Console.WriteLine("");
        Console.WriteLine("Displaying the List of Shapes");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape shape in shapes)
        {

            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");

        }

    }
}