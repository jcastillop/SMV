using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smv.Models.Entity
{
    public class DCDCatalogoDocumento
    {
        public long codigoCatalogoDocumento { get; set; }
        public DCMDocumento codigoDocumento { get; set; }
        public DCMCatalogo codigoCatalogo { get; set; }
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