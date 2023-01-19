using System;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        // Write as default to 1/1
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int wholenumber)
    {
        _top = wholenumber;
        _bottom = 1;
    }

    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    public string GetFractionString()
    {
        // We can notice this is not stored as a member variable
        // As it is a temporary local variable which will be recomputed each and every time when it is called
        string text = $"{_top}/{_bottom}";
        return text;
    }

    public double GetDecimalValue()
    {
        // We can notice that this is not stored as a member variable
        // As it is a temporary local variable which will be recomputed each and every time when it is called
        return (double)_top / (double)_bottom;
    }
}