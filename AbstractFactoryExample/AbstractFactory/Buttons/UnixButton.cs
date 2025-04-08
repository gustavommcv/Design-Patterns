using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory.Buttons;

/*
Implementação concreta do botão para Unix:
- Segue o mesmo contrato IButton, mas com comportamento diferente
- Encapsula todas as peculiaridades de renderização Unix
*/
public class UnixButton : IButton {
    public void Render() {
        Console.WriteLine("Renderizando botão no estilo unix");
        // Aqui viria o código real para renderizar um botão Unix (Linux/MacOS)
    }
}
