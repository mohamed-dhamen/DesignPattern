namespace DesignPatterns ; 

public interface ITransport
{
    void Transport();
    double GetCost(); // New requirement!
}


public class Truck : ITransport
{
    public double GetCost()
    {
       return 100 ; 
    }

    public void Transport()
    {
        Console.WriteLine(" Hello I'm a Truck, delivering by land");
    }
}

public class Ship : ITransport
{
    public double GetCost()
    {
       return 500 ; 
    }

    public void Transport()
    {
        Console.WriteLine(" Hello I'm a Ship, delivering by sea");
    }
}