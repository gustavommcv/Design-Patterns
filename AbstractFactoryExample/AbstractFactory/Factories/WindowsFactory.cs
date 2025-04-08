using AbstractFactoryExample.AbstractFactory.Buttons;
using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory.Factories;

public class WindowsFactory : IGUIFactory {
    public IButton CreateButton() => new WindowsButton();
}
