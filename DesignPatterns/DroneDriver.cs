namespace DesignPatterns ;

public class DroneDriver : IDriver
{
    public void Drive()
    {
        Console.WriteLine("I'm controlling the Drone  using command device "); 
    }
}