using System.Diagnostics;
using DesignPatterns;

public interface INotification
{
    void send(string message); 
}

public class Email : INotification
{

    public void send(string message)
    {
       Console.WriteLine($"This message '{message}' is from {this.GetType().Name}"); 
    }
}

public class SMS : INotification
{
    public void send(string message)
    {
        Console.WriteLine($"This message '{message}' is from {this.GetType().Name}"); 
    }
}

public enum NotificationType { 
    Email, 
    SMS , 
    MMS
}

public class NotificationFactory
{
    public INotification Create(NotificationType type)
    {
        return type switch
        {
            NotificationType.Email => new Email(),
            NotificationType.SMS => new SMS(),
            _ => throw new ArgumentException("The arg type not found")
        };
    }
}



public class Program
{
    public static void Main(string[] args)
    {
        // Using Factory Pattern
        Console.WriteLine("=== Factory Pattern ===");

        var factory = new NotificationFactory();
        var emailNotification = factory.Create(NotificationType.Email);
        var smsNotification = factory.Create(NotificationType.SMS);
        MessageBroker broker = MessageBroker.Instance;
        broker.OnMessageReceived += emailNotification.send;
        broker.OnMessageReceived += smsNotification.send;

        broker.Publish("Hello, World!"); 
       
    }
}   