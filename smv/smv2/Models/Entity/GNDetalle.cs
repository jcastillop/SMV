using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace smv2.Models.Entity
{
    public class GNDetalle
    {
        public int idDetalle { get; set; }
        public String descripcion { get; set; }
        public int idCabecera { get; set; }
        public int estadoRegisto { get; set; }
        public virtual GNCabecera cabecera { get; set; }

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