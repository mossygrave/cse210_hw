public class Circle : Shape
{
    //stores a radius
    private double _radius = 0;

    public Circle(double radius)
    {
        _radius = radius;
    }
    //get the area of the circle 
    public override double GetArea()
    {
        double area = Math.PI * _radius * _radius;
        return area;
    }
}