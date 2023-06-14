using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Red", 4);
        // string color = square.GetColor();
        // double area = square.GetArea();

        // Console.WriteLine($"The color is: {color}");
        // Console.WriteLine($"The area is: {area}");

        Rectangle rectangle = new Rectangle("Yellow", 6,4);
        // string colorr = rectangle.GetColor();
        // double arear = rectangle.GetArea();

        // Console.WriteLine($"The color is: {colorr}");
        // Console.WriteLine($"The area is: {arear}");

        Circle circle = new Circle("Pink", 12);
        // string colorc = circle.GetColor();
        // double areac = circle.GetArea();

        // Console.WriteLine($"The color is: {colorc}");
        // Console.WriteLine($"The area is: {areac}");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(square);
        shapes.Add(rectangle);
        shapes.Add(circle);

        foreach (Shape sh in shapes)
        {
            string color = sh.GetColor();
            double area = sh.GetArea();
            Console.WriteLine($"The {color} shape has an area of {area}");
        }
    }
}