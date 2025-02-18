public class Swimming : Activity
{
    private int laps;

    public Swimming(DateTime date, double lengthInMinutes, int laps) : base(date, lengthInMinutes)
    {
        this.laps = laps;
    }

    public override double GetDistance()
    {
        return (laps * 50.0) / 1000.0; 
    }

    public override double GetSpeed()
    {
        return (GetDistance() / lengthInMinutes) * 60;
    }

    public override double GetPace()
    {
        return lengthInMinutes / GetDistance(); 
    }

    protected override string GetUnitSpeed()
    {
        return "kph"; 
    }

    protected override string GetUnitPace()
    {
        return "min per km"; 
    }
}
