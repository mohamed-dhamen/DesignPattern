
namespace DesignPatterns;
public class SeaLogisticsFactory : ILogisticsFactory {
    public IDriver CreateDriver()
    {
        return new ShipCaptain();
    }

    public  ITransport CreateTransport() { 

        return new Ship(); 

        }
}