using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Traccion
    {
        public Traccion()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdTraccion { get; set; }
        public string NombreTraccion { get; set; } = null!;
        public int IdServicio { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
