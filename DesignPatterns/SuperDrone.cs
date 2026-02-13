// This is the "Adaptee" - The class we want to use but can't directly.
public class SuperDrone
{
    public void Beep() 
    { 
        Console.WriteLine("Beep beep! Drone activating."); 
    }

    public void SpinRotors() 
    { 
        Console.WriteLine("Rotors are spinning!"); 
    }

    public void TakeOff() 
    { 
        Console.WriteLine("Taking off and flying to destination."); 
    }
}