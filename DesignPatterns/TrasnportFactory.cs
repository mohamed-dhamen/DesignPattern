namespace DesignPatterns;


public enum TransportType
{
    Truck,
    Ship
}
public class TransportFactory
{

    public  TransportFactory() {}
    public ITransport CreateTrasnport(TransportType type)
    {
        ITransport transport =    type switch
        {
            
            TransportType.Truck => new Truck(),
            TransportType.Ship => new Ship(),
            _ => throw new ArgumentException("Invalid transport type")
        }; 
        return transport;
    }


}