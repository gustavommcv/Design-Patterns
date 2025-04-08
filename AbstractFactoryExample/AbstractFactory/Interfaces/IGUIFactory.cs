namespace AbstractFactoryExample.AbstractFactory.Interfaces;

/*
Interface Abstract Factory:
- Define o contrato para criação de famílias de objetos relacionados
- Cada método retorna uma interface (não uma implementação concreta)
- Novas plataformas podem ser adicionadas criando novas implementações
*/
public interface IGUIFactory {
    IButton CreateButton(); // Factory Method para criar botões
}
