public class Lock : IDevice
{
    public void TurnOff()
    {
        Console.WriteLine("The lock is turn-off");
    }

    public void TurnOn()
    {
        Console.WriteLine("The lock is turn-on");
    }
}