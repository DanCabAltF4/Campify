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

    }
}
