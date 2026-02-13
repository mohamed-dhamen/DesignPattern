namespace DesignPatterns ; 

public interface IRouteStrategy
{
    public double CalculateTime(double distance) ; 
}


public class RoadStrategy : IRouteStrategy
{
    public double CalculateTime(double distance)
    {
        return distance / 60 ; 
    }
}

public class WalkingStrategy : IRouteStrategy
{
    public double CalculateTime(double distance)
    {
        return distance / 5 ; 
    }
}


public class Navigator
{
   private IRouteStrategy _strategy ; 

   public Navigator(IRouteStrategy strategy) => this._strategy = strategy ; 

   public void  SetStrategy(IRouteStrategy strategy)
    {
        this._strategy = strategy ; 
    }

    public double CalculateTime(double distance )
    {
        return _strategy.CalculateTime(distance) ; 
    }

}