using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smv.Models.Entity
{
    public class DCMDocumento
    {
        public long codigoDocumento { get; set; }
        public DCMTipoDocumento codigoTipoDocumento { get; set; }
        public String descripcionDocumento { get; set; }
        public GNDetalle codigoEstadoDocumento { get; set; }
        public String codigoInterno { get; set; }
        public int estadoRegistro { get; set; }

        public DateTime fechaInsercion { get; set; }
        public String usuarioInsercion { get; set; }
        public String terminalInsercion { get; set; }
        public String ipInsercion { get; set; }
        public DateTime fechaModificacion { get; set; }
        public String usuarioModificacion { get; set; }
        public String terminalModificacion { get; set; }
        public String ipModificacion { get; set; }
    }
}