namespace DesignPatterns ; 

public class DroneAdapter: ITransport
{

    private SuperDrone _superDrone  ; 
    public DroneAdapter(SuperDrone superDrone) {

      this._superDrone = superDrone ; 
    }

    public double GetCost()
    {
        return 1000 ; 
    }

    public void Transport()
    {
      _superDrone.Beep() ; 
      _superDrone.SpinRotors();
      _superDrone.TakeOff() ; 
    }
}