namespace Model
{
    public class Parcela
    {
        public int Id { get; set; }
        public EnumTipos Tipo { get; set; }
        public double PrecioNoche { get; set; }
        public Boolean CercaBanos { get; set; }
        public Boolean TieneVistas { get; set; }
        public Boolean ZonaSombra { get; set; }
        public Boolean CercaEntrada { get; set; }
        public Boolean ZonaTranquila { get; set; }
        public EnumEstados Estado { get; set; }
        public int CapacidadMaxima { get; set; }


        public Parcela(int id, EnumTipos tipo, double precioPorNoche, bool cerca_banos, bool tiene_vistas, bool zona_sombra, bool cerca_entrada, bool zona_tranquila, EnumEstados estado, int capacidadMaxima)
        {
            Id = id;
            this.Tipo = tipo;
            PrecioNoche = precioPorNoche;
            this.CercaBanos = cerca_banos;
            this.TieneVistas = tiene_vistas;
            this.ZonaSombra = zona_sombra;
            this.CercaEntrada = cerca_entrada;
            this.ZonaTranquila = zona_tranquila;
            this.Estado = estado;
            CapacidadMaxima = capacidadMaxima;
        }
    }
}
