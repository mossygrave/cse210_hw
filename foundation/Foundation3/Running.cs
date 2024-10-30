public class Running : Activity
{
    private double _distance;

    public Running(string name, double time, double distance)
    {
        _name = name;
        _time = time;
        _distance = distance;
    }

    public double GetSpeed()
    {
        double speed = _distance / _time * 60;

        return speed;
    }

    public double GetPace()
    {
        double pace = _time / _distance;

        return pace;
    }

    public override string GetSummary()
    {
        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dd MMM yyyy");

        double speed = GetSpeed();
        double pace = GetPace();

        string summary = $"{formattedDate} {_name} ({_time} min)-Distance {_distance} km, Speed {speed} kph, Pace {pace} min per km";

        return summary;
    }

}