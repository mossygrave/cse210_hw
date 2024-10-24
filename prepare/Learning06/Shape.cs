public abstract class Shape
{
    //stores color 
    private string _color = "";
    //color setters and getters
    public void SetColor(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        //might need to set this to a new variable and return that
        return _color;
    }
    
    //get area 
    public abstract double GetArea();
}