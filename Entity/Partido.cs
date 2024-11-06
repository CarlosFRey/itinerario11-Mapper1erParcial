﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Partido
    {
        public int IdPartido { get; set; }
        public int IdDeporte { get; set; }
        public required string EquipoLocal {  get; set; }
        public required string EquipoVisitante { get; set; }
        public DateTime FechaRegistro { get; set; }
        public DateTime FechaPartido { get; set; }
        public int MarcadorLocal { get; set; }
        public int MarcadorVisitante { get; set; }
    }
}
