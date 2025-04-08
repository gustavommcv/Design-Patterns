namespace BridgeExample.src.Bridge.Implementations;

public class SamsungTV : IDevice {
    public void TurnOn() => Console.WriteLine("Samsung TV: Ligada");
    public void TurnOff() => Console.WriteLine("Samsung TV: Desligada");
    public void SetVolume(int volume) => Console.WriteLine($"Samsung TV: Volume {volume}");
}
