using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Dto
{
    public class LoginRequest
    {
        [JsonPropertyName("email")]
        public String Email { get; set; } = "";

        [JsonPropertyName("password")]
        public String Password { get; set; } =  "";
    }
}
