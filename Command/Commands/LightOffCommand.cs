using Command.Receiver;

namespace Command.Commands;

public class LightOffCommand : ICommand {
    private Light _light;
    
    public LightOffCommand(Light light) {
        _light = light;
    }

    public void Execute() => _light.TurnOff();
    public void Undo() => _light.TurnOn();
}
