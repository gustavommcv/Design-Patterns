using AbstractFactoryExample.AbstractFactory;
using AbstractFactoryExample.AbstractFactory.Factories;
using AbstractFactoryExample.AbstractFactory.Interfaces;

IGUIFactory factory = Environment.OSVersion.Platform == PlatformID.Win32NT
    ? new WindowsFactory()
    : new UnixFactory();

var app = new Application(factory);
app.RenderUI();