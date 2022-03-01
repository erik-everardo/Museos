using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museos.Tablas
{
    public class Obra
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Detalles { get; set; }
        public byte[] FotoData { get; set; }
        public DateTime FechaIncorporacion { get; set; }
    }
}
