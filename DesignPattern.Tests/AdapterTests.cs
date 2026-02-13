using DesignPatterns;

namespace DesignPattern.Tests ;
public class DroneAdapterTest
{
    
[Fact]
public void Test_DroneAdapter_Should_Work_As_Transport()
{
        ILogisticsFactory  factory = new RoadLogisticsFactory() ; 
        SuperDrone superDrone = new SuperDrone(); 
        ILogisticsFactory flightFactory = new FlightLogisticFactory(superDrone) ; 

        DeliveryInfo deliveryInfo = new DeliveryInfo(factory); 
        DeliveryInfo fligthdeliveryInfo = new DeliveryInfo(flightFactory); 
        deliveryInfo.ShowDeliveryInfo(); 
        fligthdeliveryInfo.ShowDeliveryInfo(); 
        
        Assert.Equal( typeof(TruckDriver) , deliveryInfo.driver.GetType() ) ; 
        Assert.Equal(typeof(Truck), deliveryInfo.transport.GetType()); 
        Assert.Equal(typeof(DroneAdapter), fligthdeliveryInfo.transport.GetType()); 

}

}