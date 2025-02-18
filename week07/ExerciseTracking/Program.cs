using System;
using System.Collections.Generic;

public abstract class Activity
{
    
    protected DateTime date;
    protected double lengthInMinutes;

    public Activity(DateTime date, double lengthInMinutes)
    {
        this.date = date;
        this.lengthInMinutes = lengthInMinutes;
    }

    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    public virtual string GetSummary()
    {
        return $"{date:dd MMM yyyy} {GetType().Name} ({lengthInMinutes} min): Distance {GetDistance()}, Speed {GetSpeed()} {GetUnitSpeed()}, Pace: {GetPace()} {GetUnitPace()}";
    }

    protected virtual string GetUnitSpeed()
    {
        return "mph"; 
    }

    protected virtual string GetUnitPace()
    {
        return "min per mile";
    }
}
