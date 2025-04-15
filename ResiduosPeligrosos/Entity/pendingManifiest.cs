using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{

    public class GetPendingManifiestResult_
    {
        public List<pendingManifiest> GetPendingManifiestResult { get; set; }
    }
    public class pendingManifiest
    {
        public int contenedorID { get; set; }
        public string residuo { get; set; }
        public string noParte { get; set; }
        public string material { get; set; }
        public string IEDescripcion { get; set; }
        public decimal peso { get; set; }
        public string tipoEnvase { get; set; }
        public string clasificaciones { get; set; }
        public string almacen { get; set; }
        public string locacion { get; set; }
        public string FechaAlta { get; set; }
        public string UsuarioAlta { get; set; }
        public string fechaLlenado { get; set; }
        public string UsuarioLlenado { get; set; }
        public string fechaPeso { get; set; }
        public string UsuarioPeso { get; set; }
        public decimal pesoTotal { get; set; }
        public string expira { get; set; }
        public string tiempoExpiracion { get; set; }
        public string FechaExpiracion { get; set; }
    }
}