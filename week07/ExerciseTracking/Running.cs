public class Running : Activity
{
    private double distance;

    public Running(DateTime date, double lengthInMinutes, double distance) : base(date, lengthInMinutes)
    {
        this.distance = distance;
    }

    public override double GetDistance()
    {
        return distance;
    }

    public override double GetSpeed()
    {
        return (distance / lengthInMinutes) * 60; 
    }

    public override double GetPace()
    {
        return lengthInMinutes / distance; 
    }

    protected override string GetUnitSpeed()
    {
        return "mph"; 
    }

    protected override string GetUnitPace()
    {
        return "min per mile"; 
    }
}
