using AbstractFactoryExample.AbstractFactory;
using AbstractFactoryExample.AbstractFactory.Factories;
using AbstractFactoryExample.AbstractFactory.Interfaces;

/*
Configuração inicial do Abstract Factory:
- Decide dinamicamente qual implementação de fábrica usar
- Baseado no sistema operacional onde a aplicação está rodando
- Segue o princípio Open/Closed: fácil adicionar novas factories sem modificar este código
*/
IGUIFactory factory = Environment.OSVersion.Platform == PlatformID.Win32NT
    ? new WindowsFactory()
    : new UnixFactory();

// Cria a aplicação injetando a fábrica específica
// Demonstra Injeção de Dependência: a Application não sabe qual fábrica concreta recebe
var app = new Application(factory);

// Renderiza a UI usando os componentes criados pela fábrica
// Aqui o polimorfismo entra em ação: o mesmo método funciona para qualquer SO
app.RenderUI();
