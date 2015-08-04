using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smv.Models.Entity
{
    public class DCMCatalogo
    {
        public long codigoCatalogo { get; set; }
        public String descripcionCatalogo { get; set; }
        public long codigoPadre { get; set; }
        public GNDetalle codigoTipoCatalogo { get; set; }
        public String siglasCatalogo { get; set; }
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