using BuilderExample.src.Models;

namespace BuilderExample.src.Builders;

public class CarroBuilder : ICarroBuilder {
    private Carro _carro = new Carro();

    public void SetModelo(string modelo) => _carro.Modelo = modelo;
    public void SetCor(string cor) => _carro.Cor = cor;
    public void SetAno(int ano) => _carro.Ano = ano;

    public void AdicionarArCondicionado() => _carro.ArCondicionado = true;
    public void AdicionarVidrosEletricos() => _carro.VidrosEletricos = true;
    public void AdicionarDirecaoHidraulica() => _carro.DirecaoHidraulica = true;

    public Carro GetCarro() {
        var resultado = _carro;
        Reset();
        return resultado;
    }

    private void Reset() => _carro = new Carro();
}
