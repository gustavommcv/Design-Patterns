using AdapterExample.src.Adapter.Adapters;
using AdapterExample.src.Adapter.Clients;
using AdapterExample.src.Adapter.Services;

/* Configuração inicial do padrão Adapter:
 * 1. Cria o serviço legado (que precisa ser adaptado)
 * 2. Cria o adapter que faz a ponte entre o serviço legado e a nova interface
 * 3. Cria o cliente que usará o adapter
 */
var legacyService = new ImageConverterService(); // Servico legado/concreto
var adapter = new ImageConverterAdapter(legacyService); // Adaptador
var client = new ImageProcessingClient(adapter); // Cliente que usa a interface nova

// Demonstracao do padrao em acao
client.ProcessImage("foto.png", "jpeg"); // Cliente que usa a interface moderna
