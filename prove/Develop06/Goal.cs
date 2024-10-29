//base class
public abstract class Goal
{
    //Attrubutes
    protected string _name = "";
    protected string _description = "";
    protected int _points = 0;


    //Methods
    public abstract int RecordEvent(); //i think is supposed to return void but i decided to change it for ease of points
    public abstract bool IsComplete();
    public abstract string GetStringRepresentation();

    public virtual string GetDetailsString()
    {
        string details;
        if (IsComplete() == true)
        {
            details = $"[X] {_name} ({_description}) Points: {_points}";
        }
        else 
        {
            details = $"[ ] {_name} ({_description}) Points: {_points}";
        }

        return details;
    }
}