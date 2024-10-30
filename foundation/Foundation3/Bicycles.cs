public class Bicycles : Activity
{
    private double _speed;

    public Bicycles(string name, double time, double speed)
    {
        _name = name;
        _time = time;
        _speed = speed;
    }

    public double GetPace()
    {
        double pace = 60 / _speed;

        return pace;
    }

    public override string GetSummary()
    {
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dd MMM yyyy");

        double pace = GetPace();

        string summary = $"{formattedDate} {_name} ({_time} min)-Speed {_speed} kph, Pace {pace} min per km";

        return summary;
    }
}