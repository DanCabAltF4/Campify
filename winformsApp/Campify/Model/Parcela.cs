using System.Text.Json.Serialization;

namespace Model
{
    public class Parcela
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }
        [JsonPropertyName("tipo_parcela")]
        public EnumTipos Tipo { get; set; }
        [JsonPropertyName("precio_noche")]
        public double PrecioNoche { get; set; }
        [JsonPropertyName("cerca_baño")]
        public Boolean CercaBanos { get; set; }
        [JsonPropertyName("tiene_vistas")]
        public Boolean TieneVistas { get; set; }
        [JsonPropertyName("zona_sombra")]
        public Boolean ZonaSombra { get; set; }
        [JsonPropertyName("cerca_entrada")]
        public Boolean CercaEntrada { get; set; }
        [JsonPropertyName("zona_tranquila")]
        public Boolean ZonaTranquila { get; set; }
        [JsonPropertyName("estado_parcela")]
        public EnumEstados Estado { get; set; }

        public Parcela()
        {

        }

        //public Parcela(int id, EnumTipos tipo, double precioPorNoche, bool cerca_banos, bool tiene_vistas, bool zona_sombra, bool cerca_entrada, bool zona_tranquila, EnumEstados estado)
        //{
        //    Id = id;
        //    this.Tipo = tipo;
        //    PrecioNoche = precioPorNoche;
        //    this.CercaBanos = cerca_banos;
        //    this.TieneVistas = tiene_vistas;
        //    this.ZonaSombra = zona_sombra;
        //    this.CercaEntrada = cerca_entrada;
        //    this.ZonaTranquila = zona_tranquila;
        //    this.Estado = estado;
        //}
    }
}
