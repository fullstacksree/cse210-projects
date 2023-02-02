public class Circle : Shape
{
    private double _radius;

    public Circle(string color, double radius) : base (color)
    {
        _radius = radius;
    }

    // We utilize override keyword here below
    public override double GetArea()
    {
        return _radius * _radius * Math.PI;
    }
}