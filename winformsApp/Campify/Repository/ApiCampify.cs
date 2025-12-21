using Model;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Repository
{
    public class ApiCampify
    {
        private readonly HttpClient _http;
        private readonly JsonSerializerOptions _jsonOptions= new JsonSerializerOptions();

        public ApiCampify(string http)
        {
            _http = new HttpClient { BaseAddress = new Uri(http) };
            _jsonOptions.Converters.Add(new JsonStringEnumConverter());         //Evita errores al serializar enums
            _jsonOptions.Converters.Add(new DateOnlyJsonConverter());           //Evita errores al serializar DateOnly
            _jsonOptions.Converters.Add(new NullableDateOnlyJsonConverter());   //Evita errores al serializar DateOnly? (checkout)
        }

        /// <summary>
        /// Metodo para obtener la lista de objetos desde la API de Spring Boot
        /// </summary>
        public async Task<List<T>> GetAllAsync<T>(string ruta)
        {
            var lista = await _http.GetFromJsonAsync<List<T>>(ruta, _jsonOptions);
            return lista ?? new List<T>();
        }

        /// <summary>
        /// Metodo para obtener un objeto por su ID desde la API de Spring Boot
        /// </summary>
        public async Task<T> GetByIdAsync<T>(string ruta, int id)
        {
            var objeto = await _http.GetFromJsonAsync<T>($"{ruta}/{id}", _jsonOptions);
            return objeto;
        }
        
        /// <summary>
        /// Metodo para crear un nuevo objeto y mandarle a la BD mediante la API de Spring Boot
        /// </summary>
        public async Task<T?> Create<T>(string ruta, T objeto)
        {
            //var response = await _http.PostAsJsonAsync(ruta, objeto, _jsonOptions);
            //response.EnsureSuccessStatusCode();

            //var json = await response.Content.ReadAsStringAsync();
            //System.Diagnostics.Debug.WriteLine(json);

            //return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);

            // 1) ver JSON que estás enviando
            var jsonRequest = JsonSerializer.Serialize(objeto, _jsonOptions);
            System.Diagnostics.Debug.WriteLine("REQUEST JSON: " + jsonRequest);

            // 2) hacer POST
            var response = await _http.PostAsJsonAsync(ruta, objeto, _jsonOptions);

            // 3) leer SIEMPRE el body (aunque sea 400)
            var body = await response.Content.ReadAsStringAsync();
            System.Diagnostics.Debug.WriteLine("STATUS: " + (int)response.StatusCode);
            System.Diagnostics.Debug.WriteLine("RESPONSE BODY: " + body);

            // 4) ahora sí, si falla que falle
            response.EnsureSuccessStatusCode();

            return JsonSerializer.Deserialize<T>(body, _jsonOptions);
        }

        /// <summary>
        /// Metodo para actualizar un objeto existente en la BD mediante la API de Spring Boot
        /// </summary>
        public async Task<T> Update<T>(string ruta, int id, T objeto)
        {
            var response = await _http.PutAsJsonAsync($"{ruta}/{id}", objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }

        /// <summary>
        /// Metodo para eliminar un objeto de la BD mediante la API de Spring Boot
        /// </summary>
        public async Task Delete<T>(string ruta, int id)
        {
            var response = await _http.DeleteAsync($"{ruta}/{id}");
            response.EnsureSuccessStatusCode();
        }
    }
}
