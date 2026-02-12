namespace DesignPatterns;

public class Logger {
private static readonly Lazy<Logger> logger = new Lazy<Logger>(()=> {
    return new Logger();
});

public static Logger Instance => logger.Value;

private Logger() { }    
public void Log(string message)
    {
        Console.WriteLine($"Log: {message}");
    }
}