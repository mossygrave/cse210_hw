public class Square : Shape 
{
    //stores one side 
    private double _length = 0;
    //sets the side
    public Square(double length)
    {
        _length = length;
    }
    //gets the area of the shape
    public override double GetArea()
    {
        double area = _length * _length;
        return area;
    }
}