namespace Museos.Tablas
{
    public class Museo
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Historia { get; set; }
        public DateTime FechaFundacion { get; set; }
        public byte[]? Mapa { get; set; }
        public string? Coordenadas { get; set; }
    }
}
