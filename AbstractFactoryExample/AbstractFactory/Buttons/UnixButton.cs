using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory.Buttons;

public class UnixButton : IButton {
    public void Render() {
        Console.WriteLine("Renderizando botão no estilo unix");
    }

    public void OnClick(Action action) {
        Console.WriteLine("unix button clicked!");
        action?.Invoke();
    }
}
