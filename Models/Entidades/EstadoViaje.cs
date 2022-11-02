using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class EstadoViaje
    {
        public EstadoViaje()
        {
            Viajes = new HashSet<Viaje>();
        }

        public int IdEstadoViaje { get; set; }
        public string? NombreEstadoViaje { get; set; }

        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
