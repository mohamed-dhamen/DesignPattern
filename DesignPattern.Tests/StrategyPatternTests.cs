using DesignPatterns;

namespace DesignPattern.Tests ; 

public class StrategyTest
{
    
    [Fact] 
    public void Test_WalkingStrategy_should_return_value_sup_then_Road(){

        RoadStrategy  roadStrategy = new RoadStrategy() ; 
        WalkingStrategy walkingStrategy = new WalkingStrategy(); 
        Navigator navigator = new Navigator(roadStrategy); 


        Assert.Equal(1, navigator.CalculateTime(60)); 
        navigator.SetStrategy(walkingStrategy); 
        Assert.Equal(12, navigator.CalculateTime(60)); 

    }


}