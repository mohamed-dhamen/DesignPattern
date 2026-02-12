namespace DesignPattern.Tests;
using DesignPatterns;
using Xunit.Abstractions;

public class MessageBrokerTest
{
    [Fact]
    public async Task Test_MessageBroker_with_output()
    {
        var broker = MessageBroker.Instance;
        var invocations = new List<string>();
        
        broker.OnMessageReceived +=  (msg) => 
        {
            // Console.WriteLine($"Email handler  processing for ${1000} ms :  {msg}");
            // await Task.Delay(1000); // Simulate some processing delay
            invocations.Add($"Email: {msg}");
            // Console.WriteLine($"Email handler  finished processing for ${1000} ms :  {msg}");
        };
         broker.OnMessageReceived +=  (msg) => 
        {
            // Console.WriteLine($"SMS handler processing for ${150} ms :  {msg}");
            // await  Task.Delay(150); 
            invocations.Add($"SMS: {msg}");
            // Console.WriteLine($"SMS handler finished processing for ${150} ms :  {msg}");
        };

        broker.Publish("Test");
        Assert.Equal(2, invocations.Count);
        Assert.Contains("Email: Test", invocations);
        Assert.Contains("SMS: Test", invocations);
    }


}