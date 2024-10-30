public abstract class Activity
{
    protected string _name;
    protected double _time;

    public abstract string GetSummary();

}

//get summary will be overritten
// return details which will be different for each class