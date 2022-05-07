using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museos
{

    public class Coordenada
    {
        public int X { get; set; }
        public int Y { get; set; }

        public override string ToString()
        {
            return $"{X},{Y}";
        }
    }
    public class MarcaEnImagen
    {
        public string Nombre { get; set; }
        public string Info { get; set; }
        public Coordenada Coordenada { get; set; }
    }
}
