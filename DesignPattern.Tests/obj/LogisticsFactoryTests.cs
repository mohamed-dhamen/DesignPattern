namespace DesignPattern.Tests;

public class TransportFactoryTest {
     [Fact] public void Test_TransportFactory_should_create_truck()
    {

        
        ILogisticsFactory factory = new RoadLogisticsFactory();


    }
}