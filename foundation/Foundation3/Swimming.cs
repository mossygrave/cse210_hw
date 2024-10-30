public class Swimming : Activity
{
    private double _laps;

    public Swimming(string name, double time, double laps)
    {
        _name = name;
        _time = time;
        _laps = laps;
    }

    public double GetDistance()
    {
        double distance = _laps * 50 / 1000;

        return distance;
    }

    public double GetPace()
    {
        double distance = GetDistance();
        double pace = _time / distance;

        return pace;
    }

    public double GetSpeed()
    {
        double distance = GetDistance();
        double speed = distance / _time * 60;

        return speed;
    }

    public override string GetSummary()
    {
        double speed = GetSpeed();
        double distance = GetDistance();
        double pace = GetPace();

        DateTime currentDate = DateTime.Now;
        string formattedDate = currentDate.ToString("dd MMM yyyy");

        string summary = $"{formattedDate} {_name} ({_time} min)-Distance {distance} km, Speed {speed} kph, Pace {pace} min per km";

        return summary;
    }
}