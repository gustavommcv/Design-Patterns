namespace BuilderExample.src.Models;

public class Carro {
    public string? Modelo { get; set; }
    public string? Cor { get; set; }
    public int? Ano { get; set; }
    public bool? ArCondicionado { get; set; }
    public bool? VidrosEletricos { get; set; }
    public bool? DirecaoHidraulica { get; set; }

    public void MostrarDetalhes() {
        Console.WriteLine($"Modelo: {Modelo}, Cor: {Cor}, Ano: {Ano}");
        Console.WriteLine($"Ar Condicionado: {ArCondicionado}");
        Console.WriteLine($"Vidros Elétricos: {VidrosEletricos}");
        Console.WriteLine($"Direção Hidráulica: {DirecaoHidraulica}");
    }
}
