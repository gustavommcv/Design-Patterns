using AdapterExample.src.Adapter.Interfaces;
using AdapterExample.src.Adapter.Services;

namespace AdapterExample.src.Adapter.Adapters;

/* Implementação do Adapter (o coração do padrão):
 * 1. Implementa a interface nova (IImageConverter)
 * 2. Encapsula o serviço legado (ImageConverterService)
 * 3. Faz a tradução entre as interfaces
 */
public class ImageConverterAdapter : IImageConverter {
    private readonly ImageConverterService _converterService;

    public ImageConverterAdapter(ImageConverterService converterService) {
        _converterService = converterService;
    }

    public string Convert(string imagePath, string targetFormat) {
        if (targetFormat.Equals("jpeg", StringComparison.OrdinalIgnoreCase)) {
            return _converterService.ConvertImageToJpeg(imagePath);
        }

        throw new NotSupportedException($"Formato {targetFormat} nao suportado");
    }
}
