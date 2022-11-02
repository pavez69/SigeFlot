using System;
using System.Collections.Generic;

namespace SigeFlot.Entidades
{
    public partial class ArchivoXmlGrupoArchivoXml
    {
        public int IdArchivoXml { get; set; }
        public int IdGrupoArchivoXml { get; set; }
        public int? OpcionFechaAcnoMes { get; set; }
        public int? FiltroAcno { get; set; }
        public int? FiltroAcnoMes { get; set; }
        public int? FiltroFecha { get; set; }
        public int? FiltroChofer { get; set; }
        public int? FiltroVehiculo { get; set; }
        public int? AltoVentana { get; set; }
        public int? AnchoVentana { get; set; }
    }
}
