using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();

        Square s1 = new Square(5, "red");
        shapes.Add(s1);

        Rectangle r1 = new Rectangle(3,4,"blue");
        shapes.Add(r1);

        Circle c1 = new Circle(6, "pink");
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            double area = shape.GetArea();
            Console.WriteLine(area);

            string color = shape.GetColor();    
            Console.WriteLine(color);                    
        }
    }
}
