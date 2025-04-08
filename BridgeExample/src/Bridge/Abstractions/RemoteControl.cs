using BridgeExample.src.Bridge.Implementations;

namespace BridgeExample.src.Bridge.Abstractions;

public abstract class RemoteControl {
    protected IDevice Device;

    protected RemoteControl(IDevice device) {
        Device = device;
    }

    public abstract void TogglePower();
    public abstract void VolumeUp();
    public abstract void VolumeDown();
}
