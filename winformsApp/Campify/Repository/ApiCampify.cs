using Model;
using System.Net.Http.Json;

namespace Repository
{
    public class ApiCampify
    {
        private readonly HttpClient _http;

        public ApiCampify(string http)
        {
            _http = new HttpClient { BaseAddress = new Uri(http) };
        }

        /// <summary>
        /// Metodo para obtener la lista de parcelas desde la API de Spring Boot
        /// </summary>
        public async Task<List<T>> GetAllAsync<T>(string ruta)
        {
            var lista = await _http.GetFromJsonAsync<List<T>>(ruta);
            return lista ?? new List<T>();
        }

        /// <summary>
        /// Metodo para obtener una parcela por su ID desde la API de Spring Boot
        /// </summary>
        public async Task<T?> GetByIdAsync<T>(string ruta, int id)
        {
            var objeto = await _http.GetFromJsonAsync<T>($"{ruta}/{id}");
            return objeto;
        }

        /// <summary>
        /// Metodo para crear una nueva parcela y mandarla a la BD mediante la API de Spring Boot
        /// </summary>
        public async Task<T> Create<T>(string ruta, T objeto)
        {
            var response = await _http.PostAsJsonAsync(ruta, objeto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        /// <summary>
        /// Metodo para actualizar una parcela existente en la BD mediante la API de Spring Boot
        /// </summary>
        public async Task<T> Update<T>(string ruta, int id, Task objeto)
        {
            var response = await _http.PutAsJsonAsync($"{ruta}/{id}", objeto);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>();
        }

        /// <summary>
        /// Metodo para eliminar una parcela de la BD mediante la API de Spring Boot
        /// </summary>
        public async Task Delete<T>(string ruta, int id)
        {
            var response = await _http.DeleteAsync($"{ruta}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
