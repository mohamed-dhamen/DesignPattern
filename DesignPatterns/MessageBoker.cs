namespace DesignPatterns;
public class MessageBroker
{

    private static MessageBroker? _instance;

    private static readonly object _lock = new object();

    public static MessageBroker Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new MessageBroker();
                }
            }
            return _instance;
        }
    }

    private MessageBroker() { }

    public event   Action<string>? OnMessageReceived;

    public  void Publish(string message)
    {
        Console.WriteLine($"Publishing message: {message}");
        OnMessageReceived?.Invoke(message) ;
    }
    
}