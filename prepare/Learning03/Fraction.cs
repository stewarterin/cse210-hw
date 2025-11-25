using System.Globalization;

public class Fraction
{
    private int _top;
    private int _bottom;

    public Fraction()
    {
        _top = 1;
        _bottom = 1;
    }

    public Fraction(int aNumber)
    {
        _top = aNumber;
        _bottom = 1;
    }

    public Fraction(int topNumber, int bottomNumber)
    {
        _top = topNumber;
        _bottom = bottomNumber;
    }

    public string GetFractionString()
    {
        string fractionFormat = $"{_top}/{_bottom}";
        return fractionFormat;
    }

    public double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }
}