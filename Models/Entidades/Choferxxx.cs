using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Choferxxx
    {
        public int RutChofer { get; set; }
        public int IdEstadoChofer { get; set; }
        public int? IdProvincia { get; set; }

        public virtual EstadoChofer IdEstadoChoferNavigation { get; set; } = null!;
    }
}
