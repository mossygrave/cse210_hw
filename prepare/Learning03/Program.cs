using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction1 = new Fraction();
        Fraction fraction2 = new Fraction(5);
        Fraction fraction3 = new Fraction(3, 4);

        // fraction1.DisplayFraction();
        // fraction2.DisplayFraction();
        // fraction3.DisplayFraction();

        string fractionString = fraction3.GetFractionString();
        Console.WriteLine(fractionString);

        double decimalValue = fraction3.GetDecimalValue();
        Console.WriteLine(decimalValue);
    }
}
