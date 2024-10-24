public class Rectangle : Shape
{
    // store the length and width 
    private double _length = 0;
    private double _width = 0;

    public Rectangle(double length, double width)
    {
        _length = length;
        _width = width;
    }
    // get the area of the rectangle 
    public override double GetArea()
    {
        double area = _length * _width;
        
        return area;
    }
}