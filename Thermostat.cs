public class Thermostat : IDevice
{
    public void TurnOff()
    {
        Console.WriteLine("The thermostat is turn-off");
    }

    public void TurnOn()
    {
        Console.WriteLine("The thermostat is turn-on");
    }
}