using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class EncuestaFlotaVehiculo
    {
        public int IdViaje { get; set; }
        public int IdSolicitud { get; set; }
        public int? Resp1 { get; set; }
        public int? Resp2 { get; set; }
        public int? Resp3 { get; set; }
        public int? Resp4 { get; set; }
        public int? Resp5 { get; set; }
        public int? Resp6 { get; set; }
        public int? Resp7 { get; set; }
        public int? Resp8 { get; set; }
        public DateTime? FechaRespuesta { get; set; }
    }
}
