using BridgeExample.src.Bridge.Abstractions;
using BridgeExample.src.Bridge.Implementations;

IDevice samsungTV = new SamsungTV();
IDevice lgRadio = new LGRadio();

var basicTVRemote = new BasicRemote(samsungTV);
var advancedRadioRemote = new AdvancedRemote(lgRadio);

basicTVRemote.TogglePower();
advancedRadioRemote.VolumeUp();
advancedRadioRemote.Mute();
