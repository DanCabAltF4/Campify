using Model;
using System.Net.Http.Json;

namespace Repository
{
    public class ParcelaAPI
    {
        private readonly HttpClient _http;

        public ParcelaAPI(string http)
        {
            _http = new HttpClient { BaseAddress = new Uri(http) };
        }

        public async Task<List<Parcela>> GetParcelasAsync()
        {
            var lista = await _http.GetFromJsonAsync<List<Parcela>>("api/parcelas");
            return lista ?? new List<Parcela>();
        }
    }
}
