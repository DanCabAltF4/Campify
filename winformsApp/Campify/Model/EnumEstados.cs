using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum EnumEstados
    {
        LIBRE, RESERVADA, INTERESADO, MANTENIMIENTO
    }
}
