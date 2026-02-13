namespace DesignPatterns ;

public class FlightLogisticFactory : ILogisticsFactory
{
    private SuperDrone _superDrone ; 

    public  FlightLogisticFactory (SuperDrone superDrone)
    {
         this._superDrone = superDrone ; 
    }

    public IDriver CreateDriver()
    {
        return new DroneDriver() ; 
    }

    public ITransport CreateTransport()
    {
        return  new DroneAdapter(_superDrone)  ; 
    }
}