using DesignPatterns;

namespace DesignPattern.Tests ; 

public class ObservarTest
{
    
    [Fact]

    public void Test_customer_and_warehouse_Should_have_one_notification()
    {
        Shipment shipment = new Shipment() ; 
        Customer customer = new Customer() ; 
        Warehouse warehouse = new Warehouse() ; 
        shipment.Attach(customer); 
        shipment.Attach(warehouse) ; 
        shipment.Status = "prepared" ; 

        Assert.Single(customer.LastNotifications); 
        Assert.Single(warehouse.LastLog); 
        shipment.Status = "delivered" ; 
        Assert.Equal(2, customer.LastNotifications.Count); 
        Assert.Equal(2, warehouse.LastLog.Count); 
    }

}