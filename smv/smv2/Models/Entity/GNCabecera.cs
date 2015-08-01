using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace smv2.Models.Entity
{
    public class GNCabecera
    {
        
        public int idCabecera { get; set; }
        public String descripcion { get; set; }
        public int estadoRegistro { get; set; }
        public List<GNDetalle> detalle { get; set; }

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