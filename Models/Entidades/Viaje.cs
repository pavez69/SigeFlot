using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class Viaje
    {
        public long IdViaje { get; set; }
        public int IdVehiculo { get; set; }
        public int RutChofer { get; set; }
        public int RutAdmin { get; set; }
        public DateTime FechaViaje { get; set; }
        public DateTime FechaInicio { get; set; }
        public DateTime FechaTermino { get; set; }
        public int IdHoraInicio { get; set; }
        public int IdHoraTermino { get; set; }
        public int Acno { get; set; }
        public string? Destino { get; set; }
        public int IdProvincia { get; set; }
        public int IdEstadoViaje { get; set; }
        public int KmInicio { get; set; }
        public int KmTermino { get; set; }
        public string Observacion { get; set; } = null!;
        public int IdServicio { get; set; }

        public virtual EstadoViaje IdEstadoViajeNavigation { get; set; } = null!;
        public virtual Vehiculo IdVehiculoNavigation { get; set; } = null!;
    }
}
