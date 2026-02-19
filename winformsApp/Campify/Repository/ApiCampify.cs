using Dto;
using Model;
using System.Net.Http.Headers;
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


        // Aplica el token BErarer del usuario logueado a las peticiones HTTP
        private void ApplyAuthHeader()
        {
            if (!string.IsNullOrWhiteSpace(Session.Token))
                _http.DefaultRequestHeaders.Authorization =
                    new AuthenticationHeaderValue("Bearer", Session.Token);
            else
                _http.DefaultRequestHeaders.Authorization = null;
        }


        // Peticion de login a la API
        public async Task<LoginResponse?> LoginAsync(LoginRequest req)
        {
            var response = await _http.PostAsJsonAsync("/api/auth/login", req, _jsonOptions);

            if (!response.IsSuccessStatusCode)
                return null;

            return await response.Content.ReadFromJsonAsync<LoginResponse>(_jsonOptions);
        }




        /// <summary>
        /// Metodo para obtener la lista de objetos desde la API de Spring Boot
        /// </summary>
        public async Task<List<T>> GetAllAsync<T>(string ruta)
        {
            ApplyAuthHeader();
            var lista = await _http.GetFromJsonAsync<List<T>>(ruta, _jsonOptions);
            return lista ?? new List<T>();
        }

        /// <summary>
        /// Metodo para obtener un objeto por su ID desde la API de Spring Boot
        /// </summary>
        public async Task<T> GetByIdAsync<T>(string ruta, int id)
        {
            ApplyAuthHeader();
            var objeto = await _http.GetFromJsonAsync<T>($"{ruta}/{id}", _jsonOptions);
            return objeto;
        }
        
        /// <summary>
        /// Metodo para crear un nuevo objeto y mandarle a la BD mediante la API de Spring Boot
        /// </summary>
        public async Task<T?> Create<T>(string ruta, T objeto)
        {
            ApplyAuthHeader();
            var response = await _http.PostAsJsonAsync(ruta, objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();

            var json = await response.Content.ReadAsStringAsync();
            System.Diagnostics.Debug.WriteLine(json);

            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }

        /// <summary>
        /// Metodo para actualizar un objeto existente en la BD mediante la API de Spring Boot
        /// </summary>
        public async Task<T> Update<T>(string ruta, int id, T objeto)
        {
            ApplyAuthHeader();
            var response = await _http.PutAsJsonAsync($"{ruta}/{id}", objeto, _jsonOptions);
            response.EnsureSuccessStatusCode();
            return await response.Content.ReadFromJsonAsync<T>(_jsonOptions);
        }

        /// <summary>
        /// Metodo para eliminar un objeto de la BD mediante la API de Spring Boot
        /// </summary>
        public async Task Delete<T>(string ruta, int id)
        {
            ApplyAuthHeader();
            var response = await _http.DeleteAsync($"{ruta}/{id}");
            response.EnsureSuccessStatusCode();
        }


        public static string MensajeErrorHttp(HttpRequestException ex)
        {

            int codigo = (int?)ex.StatusCode ?? -1;
            string titulo = ex.StatusCode?.ToString() ?? "ERROR";
            string mensaje = $"ERROR_CODE {codigo}: ";


            if (ex.StatusCode == System.Net.HttpStatusCode.Unauthorized)
            {
                mensaje += "Se requieren credenciales de acceso (token inválido, expirado o inexistente).";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.Forbidden)
            {
                mensaje += "No tienes permiso para realizar esta acción.";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.BadRequest)
            {
                mensaje += "Petición mal formada.";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                mensaje += "Recurso inexistente.";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                mensaje += "Error interno en el servidor.";
            }
            else if (ex.StatusCode == System.Net.HttpStatusCode.BadGateway)
            {
                mensaje += "Error en la conexión al servidor.";
            }
            else
            {
                mensaje += $"{ex.Message}";
            }
            return mensaje;
        }
    }
}
