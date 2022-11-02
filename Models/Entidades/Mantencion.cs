using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Mantencion
    {
        public int IdMantencion { get; set; }
        public int IdVehiculo { get; set; }
        public int IdTipoMantencion { get; set; }
        public DateTime FechaMantencion { get; set; }
        public string DescripcionMantencion { get; set; } = null!;

        public virtual TipoMantencion IdTipoMantencionNavigation { get; set; } = null!;
        public virtual Vehiculo IdVehiculoNavigation { get; set; } = null!;
    }
}
