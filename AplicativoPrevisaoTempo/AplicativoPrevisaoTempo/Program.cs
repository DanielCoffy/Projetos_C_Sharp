using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace AplicativoPrevisaoTempo
{
    class Program
    {
        // Método principal, ponto de entrada do aplicativo
        static async Task Main(string[] args)
        {
            Console.WriteLine("Bem-vindo ao Aplicativo de Previsão do Tempo!");

            // Solicita ao usuário o nome da cidade
            Console.WriteLine("Digite o nome da cidade: ");
            string cidade = Console.ReadLine();

            // Chave de API e URL da API de previsão do tempo
            string apiKey = "b1530a64e7d74257b1b13014242105"; // Substitua pela sua chave de API
            string url = $"http://api.weatherapi.com/v1/current.json?key={apiKey}&q={cidade}&aqi=yes";

            try
            {
                // Chama o método para obter a previsão do tempo
                PrevisaoTempo previsao = await ObterPrevisaoTempoAsync(url);

                // Verifica se a previsão foi obtida com sucesso
                if (previsao != null)
                {
                    // Exibe os dados da previsão do tempo
                    Console.WriteLine("Cidade: " + previsao.Location.Name);
                    Console.WriteLine("Temperatura: " + previsao.Current.TempC + "°C");
                    Console.WriteLine("Vento: " + previsao.Current.WindKph + " km/h, Direção: " + previsao.Current.WindDir);
                    Console.WriteLine("Umidade: " + previsao.Current.Humidity + "%");
                }
                else
                {
                    // Informa que não foi possível obter a previsão do tempo
                    Console.WriteLine("Não foi possível obter a previsão do tempo.");
                }
            }
            catch (Exception ex)
            {
                // Exibe mensagem de erro caso ocorra uma exceção
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        // Método assíncrono para obter a previsão do tempo
        static async Task<PrevisaoTempo> ObterPrevisaoTempoAsync(string url)
        {
            // Cria uma instância de HttpClient para fazer a requisição HTTP
            using (HttpClient client = new HttpClient())
            {
                // Faz a requisição GET para a URL fornecida
                HttpResponseMessage response = await client.GetAsync(url);
                // Garante que a resposta foi bem-sucedida
                response.EnsureSuccessStatusCode();

                // Lê o corpo da resposta como uma string
                string responseBody = await response.Content.ReadAsStringAsync();
                // Desserializa o JSON da resposta para um objeto PrevisaoTempo
                return JsonSerializer.Deserialize<PrevisaoTempo>(responseBody);
            }
        }
    }

    // Classe que representa a previsão do tempo
    public class PrevisaoTempo
    {
        // Propriedade para os dados de localização
        [JsonPropertyName("location")]
        public LocationData Location { get; set; }

        // Propriedade para os dados atuais do tempo
        [JsonPropertyName("current")]
        public CurrentData Current { get; set; }
    }

    // Classe que representa os dados de localização
    public class LocationData
    {
        // Nome da cidade
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

    // Classe que representa os dados atuais do tempo
    public class CurrentData
    {
        // Temperatura em Celsius
        [JsonPropertyName("temp_c")]
        public float TempC { get; set; }

        // Velocidade do vento em km/h
        [JsonPropertyName("wind_kph")]
        public float WindKph { get; set; }

        // Direção do vento
        [JsonPropertyName("wind_dir")]
        public string WindDir { get; set; }

        // Umidade em porcentagem
        [JsonPropertyName("humidity")]
        public int Humidity { get; set; }
    }

    // Classe que representa a condição do tempo (não utilizada neste código)
    public class ConditionData
    {
        // Texto descrevendo a condição do tempo
        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}
