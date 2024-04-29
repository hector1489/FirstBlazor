using System.Net.Http;
using System.Threading.Tasks;

namespace SomeDataServices
{
    public class RickAndMortyService
    {
        private readonly HttpClient _httpClient;

        public RickAndMortyService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<string> ObtenerPersonajes()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("https://rickandmortyapi.com/api/character");
            if (response.IsSuccessStatusCode)
            {
                return await response.Content.ReadAsStringAsync();
            }
            else
            {
                return null;
            }
        }
    }
}
