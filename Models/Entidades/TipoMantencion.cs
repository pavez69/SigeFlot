using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class TipoMantencion
    {
        public TipoMantencion()
        {
            Mantencions = new HashSet<Mantencion>();
        }

        public int IdTipoMantencion { get; set; }
        public string NombreTipoMantencion { get; set; } = null!;

        public virtual ICollection<Mantencion> Mantencions { get; set; }
    }
}
