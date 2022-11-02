using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class TipoCombustible
    {
        public TipoCombustible()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdTipoCombustible { get; set; }
        public string NombreTipoCombustible { get; set; } = null!;
        public int IdServicio { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
