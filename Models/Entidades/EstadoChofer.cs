using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class EstadoChofer
    {
        public EstadoChofer()
        {
            Choferxxxes = new HashSet<Choferxxx>();
        }

        public int IdEstadoChofer { get; set; }
        public string? NombreEstadoChofer { get; set; }

        public virtual ICollection<Choferxxx> Choferxxxes { get; set; }
    }
}
