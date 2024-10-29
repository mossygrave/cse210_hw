public class EternalGoal : Goal
{
    //no attributes
    int _timesCompleted = 0; //number of times the goal has been completed

    public EternalGoal(string name, string description, int points)
    {
        _name = name;
        _description = description;
        _points = points;
    }

    //added an extra constructor to simplify loading from a file
    public EternalGoal(string name, string description, int points, int times)
    {
        _name = name;
        _description = description;
        _points = points;
        _timesCompleted = times;
    }

    public override int RecordEvent()
    {
       //add points to score
       //add to counter to show how mnay times it has been completed
       _timesCompleted += 1;
       int points = _points;
       return points;
    }

    public override bool IsComplete()
    {
        bool complete = false;
    
        return complete;
    }

    public override string GetDetailsString()
    {
        string details;
        if (IsComplete() == true)
        {
            details = $"[X] {_name} ({_description}) Points: {_points} Times Completed: {_timesCompleted}";
        }
        else 
        {
            details = $"[ ] {_name} ({_description}) Points: {_points} Times Completed: {_timesCompleted}";
        }

        return details;
    }

    public override string GetStringRepresentation()
    {
        //turn the goal into a string so it can be saved and loaded
        string goal = $"Eternal Goal~~{_name}~~{_description}~~{_points}~~{_timesCompleted}";


        return goal;
    }
}