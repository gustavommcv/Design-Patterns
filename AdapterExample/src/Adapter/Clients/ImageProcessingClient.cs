using AdapterExample.src.Adapter.Interfaces;

namespace AdapterExample.src.Adapter.Clients;

/* Cliente que usa o padrão Adapter:
 * - Trabalha apenas com a interface nova (IImageConverter)
 * - Não conhece a implementação legada (ImageConverterService)
 * - Recebe o adapter via injeção de dependência (melhor prática)
 */
public class ImageProcessingClient {
    private readonly IImageConverter _converter;

    public ImageProcessingClient(IImageConverter converter) {
        _converter = converter;
    }

    public void ProcessImage(string path, string format) {
        var result = _converter.Convert(path, format);
        Console.WriteLine($"Resultado: {result}");
    }
}
