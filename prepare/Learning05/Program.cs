using System;

class Program
{
    static void Main(string[] args)
    {
        
        List<Shape> shapes = new List<Shape>();

        Square d1 = new Square("White", 4);
        shapes.Add(d1);

        Rectangle d2 = new Rectangle("Yellow", 2, 4);
        shapes.Add(d2);

        Circle d3 = new Circle("Violet", 8);
        shapes.Add(d3);

        foreach (Shape d in shapes)
        {
            // In all the shapes the base class has a GetColor method
            string color = d.GetColor();

            // In all the shapes they have a GetArea method, even though the dehavior is different from each shape
            double area = d.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}");
        }

    }
}