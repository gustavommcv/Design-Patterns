using AbstractFactoryExample.AbstractFactory.Buttons;
using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory.Factories;

public class UnixFactory : IGUIFactory {
    public IButton CreateButton() => new UnixButton();
}
