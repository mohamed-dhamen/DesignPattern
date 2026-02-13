namespace DesignPatterns;

public class Shipment
{
    // 1. Private Backing Field
    private string? _status; 

    // 2. The List of Listeners (Use the Interface!)
    private List<IObserver> _subscribers = new List<IObserver>();

    public string? Status
    {
        get => _status;
        set
        {
            // Only notify if the value actually changed
            if (_status != value && value != null)
            {
                _status = value;      // Assign to private field
                Notify(value);        // Notify everyone
            }
        }
    }

    public void Attach(IObserver observer)
    {
        _subscribers.Add(observer);
    }

    public void Notify(string message)
    {
        // Loop through the list and update everyone
        _subscribers.ForEach(s => s.Update(message));
    }
}