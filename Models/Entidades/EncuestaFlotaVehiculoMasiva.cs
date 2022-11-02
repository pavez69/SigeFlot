using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class EncuestaFlotaVehiculoMasiva
    {
        public int Rut { get; set; }
        public int? Respondida { get; set; }
        public DateTime? FechaRespuesta { get; set; }
        public int? Resp1 { get; set; }
        public int? Resp2 { get; set; }
        public int? Resp3 { get; set; }
        public int? Resp4 { get; set; }
        public int? Resp5 { get; set; }
        public int? Resp6 { get; set; }
        public int? Resp7 { get; set; }
        public string? Observacion { get; set; }
    }
}
