using AbstractFactoryExample.AbstractFactory.Interfaces;

namespace AbstractFactoryExample.AbstractFactory;

/*
Classe cliente do Abstract Factory:
- Não conhece as implementações concretas (Windows/Unix)
- Depende apenas de abstrações (IGUIFactory, IButton)
- Fácil de testar (pode receber mocks no lugar das factories reais)
*/
public class Application {
    private readonly IButton _button;

    // Injeção de Dependência via construtor:
    // - Recebe a fábrica abstrata (não cria internamente)
    // - Permite fácil substituição para testes ou novas plataformas
    public Application(IGUIFactory factory) {
        _button = factory.CreateButton();
    }

    // Método que usa o componente criado pela fábrica
    public void RenderUI() {
        _button.Render();  // Chama o método renderizado específico da plataforma
    }
}
