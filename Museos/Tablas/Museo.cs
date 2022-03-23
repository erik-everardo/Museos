using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
