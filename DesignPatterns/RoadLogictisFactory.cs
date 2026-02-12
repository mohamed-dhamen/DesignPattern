namespace DesignPatterns;

public class RoadLogisticsFactory : ILogisticsFactory {
    public IDriver CreateDriver()
    {
        return new TruckDriver();
    }

    public  ITransport CreateTransport() { 
            return new Truck(); 
        } 
     
}
