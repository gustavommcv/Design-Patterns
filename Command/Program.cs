using Command.Commands;
using Command.Invoker;
using Command.Receiver;

var light = new Light();

var lightOn = new LightOnCommand(light);
var lightOff = new LightOffCommand(light);

var remote = new RemoteControl();
remote.SetCommand(lightOn);
remote.PressButton(); // Luz ligada

remote.SetCommand(lightOff);
remote.PressButton();
remote.PressUndo();
