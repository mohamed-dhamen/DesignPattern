namespace DesignPatterns ; 

public interface ITransport
{
    void Transport();
}


public class Truck : ITransport
{
    public void Transport()
    {
        Console.WriteLine(" Hello I'm a Truck, delivering by land");
    }
}

public class Ship : ITransport
{
    public void Transport()
    {
        Console.WriteLine(" Hello I'm a Ship, delivering by sea");
    }
}