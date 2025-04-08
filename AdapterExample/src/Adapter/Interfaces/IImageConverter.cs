namespace AdapterExample.src.Adapter.Interfaces;

/* Interface alvo (Target) do padrão Adapter:
 * - Define a interface que o cliente espera usar
 * - O adapter implementará esta interface
 */
public interface IImageConverter {
    string Convert(string imagePath, string targetFormat);
}
