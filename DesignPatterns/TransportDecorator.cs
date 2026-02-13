namespace DesignPatterns  ;

public abstract class TransportDecorator : ITransport
{
    private ITransport transport ; 
    public TransportDecorator( ITransport transport)
    {
        this.transport = transport ; 
    }
    public virtual  double GetCost()
    {
       return transport.GetCost(); 
    }

    public  virtual void Transport()
    {
        transport.Transport(); 

    }
}