using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class EstadoVehiculo
    {
        public EstadoVehiculo()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdEstadoVehiculo { get; set; }
        public string NombreEstadoVehiculo { get; set; } = null!;

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
