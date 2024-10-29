public class SimpleGoal : Goal
{
    //attributes
    private bool _isComplete = false;

    //constructor
    public SimpleGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    //added an extra constructor to simplify loading from a file
    public SimpleGoal(string name, string description, int points, bool isComplete)
    {
        _name = name;
        _description = description;
        _points = points;
        _isComplete = isComplete;
    }

    public override int RecordEvent()
    {
        //marks the goal as complete
        _isComplete = true;
        //add points to the score
        int points = _points;
        return points;
    }

    public override bool IsComplete()
    {
        //returns if the goal is complete or not
        return _isComplete;
    }

    public override string GetStringRepresentation()
    {
        //turn the goal into a string so it can be saved and loaded
        string goal = $"Simple Goal~~{_name}~~{_description}~~{_points}~~{_isComplete}";
        
        return goal;
    }
}