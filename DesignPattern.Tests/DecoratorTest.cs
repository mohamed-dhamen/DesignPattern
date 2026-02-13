using DesignPatterns;

namespace DesignPattern.Tests ; 

public class DecoratorTest
{
   [Fact]
public void Test_Decorators_Should_Stack_Costs_Correctly()
{
    SuperDrone superDrone = new SuperDrone(); 
    ILogisticsFactory FlightFactory  = new FlightLogisticFactory(superDrone);
    ITransport drone = FlightFactory.CreateTransport() ; 
    TransportDecorator transport = new FragileTransport(drone); 
    Assert.Equal(1050,transport.GetCost()); 
    
    TransportDecorator refrigeredtedTransport = new RefrigeratedTransport(drone); 
    Assert.Equal(1200, refrigeredtedTransport.GetCost());
    refrigeredtedTransport.Transport();
}


}