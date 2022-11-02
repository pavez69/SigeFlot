using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Color
    {
        public Color()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdColor { get; set; }
        public string NombreColor { get; set; } = null!;
        public int IdServicio { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
