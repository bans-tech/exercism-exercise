class RemoteControlCar
{
    private int _distance;
    private double _battery = 100;
    
    public static RemoteControlCar Buy()
    {
        var newCar = new RemoteControlCar();
        return newCar;
    }

    public string DistanceDisplay()
    {
        string display = $"Driven {_distance} meters";
        return display;
    }

    public string BatteryDisplay()
    {
        if (_battery == 0)
        {
            return "Battery empty";
        }
        else
        {
            string display = $"Battery at {_battery}%";
            return display;
        }        
    }

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
