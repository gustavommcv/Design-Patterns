using AbstractFactoryExample.AbstractFactory.Buttons;
using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory.Factories;

/*
Implementação concreta da fábrica para Windows:
- Sabe quais classes concretas criar para a plataforma Windows
- Cada método retorna um produto específico da plataforma
*/
public class WindowsFactory : IGUIFactory {
    public IButton CreateButton() => new WindowsButton(); // Retorna um botão estilo Windows
}
