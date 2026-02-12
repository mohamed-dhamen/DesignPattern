using System.Reflection.Metadata;
using DesignPatterns;

namespace DesignPattern.Tests;


public class SingletonTest
{
    [Fact]
    public void Test_Singleton_should_return_same_instance()
    {
       
      var logger1 = Logger.Instance;
      var logger2 = Logger.Instance ; 

      logger1.Log("This is a log message from logger1");
      logger2.Log("This is a log message from logger2");
    
      Assert.Same(logger1, logger2);
      
    }
}