public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, int points, int target, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _target = target;
        _bonus = bonus;
    }

    //added an extra constructor to simplify loading from a file
    public ChecklistGoal(string name, string description, int points, int completed, int target, int bonus)
    {
        _name = name;
        _description = description;
        _points = points;
        _amountCompleted = completed;
        _target = target;
        _bonus = bonus;
    }

    public override int RecordEvent()
    {
        //add one to amountCompleted
        _amountCompleted += 1;
        int points = _points;
        
        //run IsComplete if true add bonus
        if (IsComplete() == true)
        {
            points += _bonus;
        }

        return points;
    }

    public override bool IsComplete()
    {
        bool complete;
        if (_amountCompleted == _target)
        {
            complete = true;
        }
        else
        {
            complete = false;
        }

        return complete;
    }

    public override string GetDetailsString()
    {
        //return name description amount completed and target

        string details = $"{_name} {_description} {_amountCompleted}/{_target} Points: {_points} Bonus Points: {_bonus}";     
        string str;

        if (IsComplete() == true)
        {
            str = $"[X] {details}";
        }
        else
        {
            str = $"[ ] {details}";
        }

        return str;   
    }

    public override string GetStringRepresentation()
    {
        //turn the goal into a string so it can be saved and loaded
        string details = $"Checklist Goal~~{_name}~~{_description}~~{_points}~~{_amountCompleted}~~{_target}~~{_bonus}";


        return details;
    }
}