public class Fraction
{
    private int _numerator;
    private int _denominator;
    private string fraction;
    private double decimalValue;

    public Fraction()
    {
        //no parameters
        //makes the fraction 1/1
        _numerator = 1;
        _denominator = 1;

    }

    public Fraction(int numerator)
    {
        //one parameter (numerator)
        //makes the fraction numerator/1
        _numerator = numerator;
        _denominator = 1;

    }

    public Fraction(int numerator, int denominator)
    {
        //two parameters (numerator and denominator)
        //makes the fraction numerator/denominator
        _numerator = numerator;
        _denominator = denominator;

    }

    public void DisplayFraction()
    {
        Console.WriteLine($"{_numerator}/{_denominator}");
    }

    public string GetFractionString()
    {
        fraction = $"{_numerator}/{_denominator}";
        return fraction;
    }

    public double GetDecimalValue()
    {
        decimalValue = (double)_numerator / (double)_denominator;
        return decimalValue;
    }
}