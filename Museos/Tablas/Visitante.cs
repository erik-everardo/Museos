﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Museos.Tablas
{
    public class Visitante
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public DateTime Fecha { get; set; }
    }
}
