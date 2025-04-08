using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory.Buttons;


/*
Implementação concreta do botão para Windows:
- Contém a lógica específica de renderização para Windows
- Pode conter outros métodos específicos da plataforma
*/
public class WindowsButton : IButton {
    public void Render() {
        Console.WriteLine("Renderizando botão no estilo Windows");
        // Aqui viria o código real para renderizar um botão Windows
    }
}
