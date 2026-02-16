using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dto
{
    public class LoginResponse
    {
        [JsonPropertyName("token")]
        public String Token { get; set; } 

        [JsonPropertyName("rol")]
        public String Puesto { get; set; }
        
        [JsonPropertyName("id")]
        public int Id { get; set; }
    }
}
