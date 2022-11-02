using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class TipoCarrocerium
    {
        public TipoCarrocerium()
        {
            Vehiculos = new HashSet<Vehiculo>();
        }

        public int IdTipoCarroceria { get; set; }
        public string NombreTipoCarroceria { get; set; } = null!;
        public int IdServicio { get; set; }

        public virtual ICollection<Vehiculo> Vehiculos { get; set; }
    }
}
