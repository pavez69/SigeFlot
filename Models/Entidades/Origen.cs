using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Origen
    {
        public Origen()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdOrigen { get; set; }
        public string NombreOrigen { get; set; } = null!;
        public int IdServicio { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
