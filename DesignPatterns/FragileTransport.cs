namespace DesignPatterns ;

public class FragileTransport : TransportDecorator
{
    public FragileTransport(ITransport transport) : base(transport)
    {
    }


    public override double GetCost()
    {
        return base.GetCost()+50 ; 

    }
 public override void Transport()
{
    Console.WriteLine("⚠️ FRAGILE: Handle with care!"); // Add this behavior
    base.Transport(); // Then do the actual work
}
}