namespace DesignPatterns;

public class Customer : IObserver
{
    public List<string> LastNotifications { get; private set; }  = new List<string>(); 

    public void Update(string message)
    {
        LastNotifications.Add(message) ; 
        Console.WriteLine(message);
    }
}

