using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Destino
    {
        public int IdDestino { get; set; }
        public int IdComuna { get; set; }
        public int IdLocalidad { get; set; }
        public int IdViaje { get; set; }
        public int TipoDestino { get; set; }
    }
}
