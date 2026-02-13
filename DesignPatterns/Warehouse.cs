namespace DesignPatterns ;

public class Warehouse : IObserver
{
    public List<string> LastLog { get; private set; } = new List<string>();

    public void Update(string message)
    {
        LastLog.Add(message);
        Console.WriteLine(message);
    }
}