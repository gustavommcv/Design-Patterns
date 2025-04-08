namespace AdapterExample.src.Adapter.Services;

/* Serviço legado que precisa ser adaptado:
 * - Contém a implementação concreta, mas com interface incompatível
 * - No padrão Adapter, esta classe é o "Adaptee" (o que será adaptado)
 */
public class ImageConverterService {
    public string ConvertImageToJpeg(string imagePath) {
        Console.WriteLine($"Convertendo {imagePath} para JPEG...");
        return $"{Path.GetFileNameWithoutExtension(imagePath)}.jpeg";
    }
}
