using BuilderExample.src.Models;

namespace BuilderExample.src.Builders;

public interface ICarroBuilder {
    void SetModelo(string modelo);
    void SetCor(string cor);
    void SetAno(int ano);
    void AdicionarArCondicionado();
    void AdicionarVidrosEletricos();
    void AdicionarDirecaoHidraulica();
    Carro GetCarro();
}
