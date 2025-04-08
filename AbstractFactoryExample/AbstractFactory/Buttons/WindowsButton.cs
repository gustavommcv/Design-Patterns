using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory.Buttons;

public class WindowsButton : IButton
{
    public void Render() {
        Console.WriteLine("Renderizando botão no estilo Windows");
    }

    public void OnClick(Action action) {
        Console.WriteLine("Windows button clicked!");
        action?.Invoke();
    }
}
