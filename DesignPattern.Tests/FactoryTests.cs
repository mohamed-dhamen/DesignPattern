namespace DesignPattern.Tests;

public class FactoryTests
{
    [Fact]
    public void Test_Factory_Methode_should_create_correct_notification_type()
    {

        // arrange 
        var factory = new NotificationFactory();
        var email = factory.Create(NotificationType.Email);
        var sms = factory.Create(NotificationType.SMS);
        // assert
        Assert.IsType<Email>(email);    
        Assert.IsType<SMS>(sms);

    }


    [Fact]
    public void Test_Factory_should_return_exception_for_invalid_notification_type()
    {

        // arrange 
        var factory = new NotificationFactory();
        Assert.Throws<ArgumentException>(() => factory.Create(NotificationType.MMS));

    }

}
