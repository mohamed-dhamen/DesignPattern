namespace DesignPatterns;

public class DeliveryInfo { 
    public  IDriver driver {get ; init ;}  
    public  ITransport transport {get ; init ; } 

    public DeliveryInfo(ILogisticsFactory logisticsFactory) { 

            driver = logisticsFactory.CreateDriver(); 
            transport = logisticsFactory.CreateTransport(); 
        } 
        
    public void ShowDeliveryInfo() { 
            driver.Drive();
            transport.Transport(); 
        } 
        
        
}


