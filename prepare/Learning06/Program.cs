using System;

class Program
{
    static void Main(string[] args)
    {
        Rectangle rectangle = new Rectangle(5, 10);
        Circle circle = new Circle(3);
        Square square = new Square(4);

        rectangle.SetColor("Red");
        circle.SetColor("Blue");
        square.SetColor("Yellow");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(rectangle);
        shapes.Add(circle);
        shapes.Add(square);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            double area = shape.GetArea();

            Console.WriteLine($"The color is {color} and the area is {area}.");
        }
    }
}