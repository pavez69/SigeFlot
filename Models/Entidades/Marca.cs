using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Marca
    {
        public Marca()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdMarca { get; set; }
        public string NombreMarca { get; set; } = null!;
        public int IdServicio { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
