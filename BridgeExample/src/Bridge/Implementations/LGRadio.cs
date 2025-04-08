namespace BridgeExample.src.Bridge.Implementations;

public class LGRadio : IDevice {
    public void TurnOn() => Console.WriteLine("LG Rádio: Ligado");
    public void TurnOff() => Console.WriteLine("LG Rádio: Desligado");
    public void SetVolume(int volume) => Console.WriteLine($"LG Rádio: Volume {volume}");
}
