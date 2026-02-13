namespace DesignPatterns;

public class Route
{
    public string StartPoint { get; set; }
    public string EndPoint { get; set; }
    public List<string> Stops { get; set; } = new List<string>();
    public bool AvoidTolls { get; set; }
    public bool AvoidTraffic { get; set; }

    public override string ToString()
    {
        return $"Route from {StartPoint} to {EndPoint} " +
               $"(Stops: {Stops.Count}, Avoid Tolls: {AvoidTolls})";
    }

    public  Route (){}
    

}