using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museos.Tablas
{
    public class Boleto
    {
        public Guid Id { get; set; }
        public bool Used { get; set; }
        public DateTime DateIssued { get; set; }
    }
}
