using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museos.Tablas
{
    public class ComentarioMuseo
    {
        public Guid Id { get; set; }
        public Guid UidVisitante { get; set; }
        public string TextoContenido { get; set; }
        public DateTime Fecha { get; set; }
        public int Calificacion { get; set; }
    }
}
