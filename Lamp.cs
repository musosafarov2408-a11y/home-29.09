public class Lamp : IDevice
{
    public void TurnOff()
    {
        Console.WriteLine("The lamp is turn-off");
    }

    public void TurnOn()
    {
        Console.WriteLine("The lamp is turn-on");
    }
}