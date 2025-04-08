using BuilderExample.src.Builders;

var builder = new CarroBuilder();

builder.SetModelo("Basico");
builder.SetCor("Preto");
builder.AdicionarArCondicionado();
builder.AdicionarVidrosEletricos();

var carro = builder.GetCarro();

carro.MostrarDetalhes();
