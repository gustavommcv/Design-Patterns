using AbstractFactoryExample.AbstractFactory.Buttons;
using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory.Factories;

/*
Implementação concreta da fábrica para Unix (Linux/MacOS):
- Cria produtos que seguem o estilo visual Unix
- Mesma interface que WindowsFactory, mas implementação diferente
*/
public class UnixFactory : IGUIFactory {
    public IButton CreateButton() => new UnixButton(); // Retorna um botão estilo Unix
}
