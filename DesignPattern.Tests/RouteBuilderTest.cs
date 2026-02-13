namespace DesignPatterns.Tests ; 

public class RouteBuilderTest
{
    
   [Fact]
public void RouteBuilder_should_return_Route_with_correct_stops()
{
    // Arrange
    var builder = new RouteBuilder(); // Use camelCase for variables

    // Act
    var route = builder
        .From("Taza")
        .To("Casablanca")
        .AddStop("Rabat")
        .AddStop("Mohammedia") // Added another stop for fun
        .WithTrafficAvoidance()        // Assuming you updated the method name as discussed
        .AvoidTolls()
        .Build();

    // Assert
    Assert.NotNull(route.StartPoint);
    Assert.Equal("Taza", route.StartPoint);
    
    // Verifying the list of stops
    // We check that "Rabat" is inside the list of stops
    Assert.Contains("Rabat", route.Stops);
    
    // Or we can verify the exact count
    Assert.Equal(2, route.Stops.Count);
    
    // Verify the boolean flags
    Assert.True(route.AvoidTraffic);
    Assert.True(route.AvoidTolls);
}
}