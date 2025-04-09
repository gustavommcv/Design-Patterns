using Command.Commands;

namespace Command.Invoker;

public class RemoteControl {
    private ICommand _command;
    private Stack<ICommand> _history = new Stack<ICommand>();

    public void SetCommand(ICommand command) {
        _command = command;
    }

    public void PressButton() {
        _command.Execute();
        _history.Push(_command);
    }

    public void PressUndo() {
        if (_history.Count > 0) {
            var lastCommand = _history.Pop();
            lastCommand.Undo();
        }
    }
}
