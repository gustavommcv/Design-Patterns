using BridgeExample.src.Bridge.Implementations;

namespace BridgeExample.src.Bridge.Abstractions;

public class AdvancedRemote : RemoteControl {
    public AdvancedRemote(IDevice device) : base(device) { }

    public override void TogglePower() {
        Console.WriteLine("Controle Avançado: Botão Power");
        Device.TurnOn();
    }

    public override void VolumeUp() => Device.SetVolume(20);
    public override void VolumeDown() => Device.SetVolume(0);
    
    public void Mute() => Device.SetVolume(0);
}