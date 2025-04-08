using BridgeExample.src.Bridge.Implementations;

namespace BridgeExample.src.Bridge.Abstractions;

public class BasicRemote : RemoteControl {
    public BasicRemote(IDevice device) : base(device) {}

    public override void TogglePower() {
        Console.WriteLine("Controle basico - Botao power");
        Device.TurnOff();
    }

    public override void VolumeUp() => Device.SetVolume(10);
    public override void VolumeDown() => Device.SetVolume(5);
}
