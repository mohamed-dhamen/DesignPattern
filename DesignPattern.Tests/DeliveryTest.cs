using DesignPatterns;

namespace DesignPattern.Tests;

public class TransportFactoryTest
{
    
    [Fact]
    public void Test_Delivery_should_CreateTruck_and_drive()
    {
        ILogisticsFactory  factory = new RoadLogisticsFactory() ; 
        DeliveryInfo deliveryInfo = new DeliveryInfo(factory); 
        deliveryInfo.ShowDeliveryInfo(); 
        
        Assert.Equal( typeof(TruckDriver) , deliveryInfo.driver.GetType() ) ; 
        Assert.Equal(typeof(Truck), deliveryInfo.transport.GetType()); 

    }

}

