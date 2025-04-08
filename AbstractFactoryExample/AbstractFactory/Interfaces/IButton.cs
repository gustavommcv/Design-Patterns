namespace AbstractFactoryExample.AbstractFactory.Interfaces;

public interface IButton {
    void Render();
    void OnClick(Action action);
}
