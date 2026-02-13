using DesignPatterns;

public class RouteBuilder {
    private Route route  ; 

    public RouteBuilder()
    {
        route = new Route(); 
    }

    public RouteBuilder From(string startPoint) {
        route.StartPoint = startPoint ; 
        return this ; 
    }
    public RouteBuilder To(string startPoint) {
        route.EndPoint = startPoint ; 
        return this ; 
    }
    public RouteBuilder AddStop(string stop) {
        route.Stops.Add(stop); 
        return this; 
    }

    public RouteBuilder WithTrafficAvoidance() {
        route.AvoidTraffic = true ; 
        return this ; 
    }

     public RouteBuilder AvoidTolls() {
        route.AvoidTolls = true; 
        return this; 
    }

    public Route Build()
    {
        return route ; 
    }

}