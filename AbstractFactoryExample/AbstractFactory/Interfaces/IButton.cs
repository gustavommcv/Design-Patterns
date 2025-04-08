namespace AbstractFactoryExample.AbstractFactory.Interfaces;

/*
Interface do produto (Button):
- Define a interface comum para todos os botões, independente da plataforma
- As implementações concretas (WindowsButton, UnixButton) devem seguir este contrato
*/
public interface IButton {
    void Render(); // Como o botão deve se renderizar na tela
}
