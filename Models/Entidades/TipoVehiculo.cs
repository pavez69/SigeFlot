using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class TipoVehiculo
    {
        public TipoVehiculo()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdTipoVehiculo { get; set; }
        public string NombreTipoVehiculo { get; set; } = null!;
        public int IdServicio { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
