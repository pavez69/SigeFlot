using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Vehiculo
    {
        public Vehiculo()
        {
            Mantencions = new HashSet<Mantencion>();
            Viajes = new HashSet<Viaje>();
        }

        public int IdVehiculo { get; set; }
        public int IdMarca { get; set; }
        public int IdTipoVehiculo { get; set; }
        public int IdTipoCombustible { get; set; }
        public int IdTraccion { get; set; }
        public int IdColor { get; set; }
        public int IdTipoCarroceria { get; set; }
        public int IdEstadoVehiculo { get; set; }
        public int IdOrigen { get; set; }
        public string Patente { get; set; } = null!;
        public string Modelo { get; set; } = null!;
        public int Acno { get; set; }
        public int NumeroAsientos { get; set; }
        public string NumeroMotor { get; set; } = null!;
        public string NumeroChasis { get; set; } = null!;
        public int IdProvincia { get; set; }
        public string NumeroInventario { get; set; } = null!;
        public int KmActual { get; set; }
        public int IdServicio { get; set; }

        public virtual Color IdColorNavigation { get; set; } = null!;
        public virtual EstadoVehiculo IdEstadoVehiculoNavigation { get; set; } = null!;
        public virtual Marca IdMarcaNavigation { get; set; } = null!;
        public virtual Origen IdOrigenNavigation { get; set; } = null!;
        public virtual TipoCarrocerium IdTipoCarroceriaNavigation { get; set; } = null!;
        public virtual TipoCombustible IdTipoCombustibleNavigation { get; set; } = null!;
        public virtual TipoVehiculo IdTipoVehiculoNavigation { get; set; } = null!;
        public virtual Traccion IdTraccionNavigation { get; set; } = null!;
        public virtual ICollection<Mantencion> Mantencions { get; set; }
        public virtual ICollection<Viaje> Viajes { get; set; }
    }
}
