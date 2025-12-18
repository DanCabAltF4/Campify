namespace Model
{
    public class Parcela
    {
        public int Id { get; set; }
        public EnumTipos tipo { get; set; }
        public double PrecioPorNoche { get; set; }
        public Boolean cerca_banos { get; set; }
        public Boolean tiene_vistas { get; set; }
        public Boolean zona_sombra { get; set; }
        public Boolean cerca_entrada { get; set; }
        public Boolean zona_tranquila { get; set; }
        public EnumEstados estado { get; set; }
        public int CapacidadMaxima { get; set; }


        public Parcela(int id, EnumTipos tipo, double precioPorNoche, bool cerca_banos, bool tiene_vistas, bool zona_sombra, bool cerca_entrada, bool zona_tranquila, EnumEstados estado, int capacidadMaxima)
        {
            Id = id;
            this.tipo = tipo;
            PrecioPorNoche = precioPorNoche;
            this.cerca_banos = cerca_banos;
            this.tiene_vistas = tiene_vistas;
            this.zona_sombra = zona_sombra;
            this.cerca_entrada = cerca_entrada;
            this.zona_tranquila = zona_tranquila;
            this.estado = estado;
            CapacidadMaxima = capacidadMaxima;
        }
    }
}
