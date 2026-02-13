namespace DesignPatterns ;

public class RefrigeratedTransport : TransportDecorator
{

    public RefrigeratedTransport(ITransport transport) : base(transport)
    {
    }


    public override double GetCost()
    {
        return base.GetCost() + 200  ; 
    }


    public override void Transport()
    {
        Console.WriteLine(" ❄️  Keeping it cool!before transporting.") ; 
        base.Transport();
    }
}