public class Rectangle : Shape
{
    private double _length;
    private double _width;

    public Rectangle(string color, double length, double width) : base (color)
    {
        _length = length;
        _width = width;
    }

    // We utilize override keyword here below
    public override double GetArea()
    {
        return _length * _width;
    }
}