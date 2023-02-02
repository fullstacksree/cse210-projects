// In this I will be using abstract method as I have studied in the material provided as it helps to simple the code

public abstract class Shape
{
    private string _color;
    public Shape(string color)
    {
        _color = color;

    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();

}