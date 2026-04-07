class RemoteControlCar
{
    private int _distance;
    private double _battery = 100;
    
    public static RemoteControlCar Buy()
    {
        var newCar = new RemoteControlCar();
        return newCar;
    }

    public string DistanceDisplay() => $"Driven {_distance} meters";

    // OR this method (both works):
    // {
    //     return $"Driven {_distance} meters";
    // }

    public string BatteryDisplay() => _battery == 0 ? "Battery empty" : $"Battery at {_battery}%";
    
    // {
    //     if (_battery == 0)
    //     {
    //         return "Battery empty";
    //     }
    //     else
    //     {
    //         return $"Battery at {_battery}%";
    //     }        
    // }

    public void Drive()
    {
        if (_battery > 0)
        {
            _distance = _distance + 20;
            _battery = _battery - 1;
        }
        else if (_battery == 0)
        {
            BatteryDisplay();
        }          
    }    
}
