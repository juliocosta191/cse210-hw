public class Cycling : Activity
{
    private double speed;

    public Cycling(DateTime date, double lengthInMinutes, double speed) : base(date, lengthInMinutes)
    {
        this.speed = speed;
    }

    public override double GetDistance()
    {
        return (speed * lengthInMinutes) / 60; 
    }

    public override double GetSpeed()
    {
        return speed; 
    }

    public override double GetPace()
    {
        return 60 / speed; 
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
