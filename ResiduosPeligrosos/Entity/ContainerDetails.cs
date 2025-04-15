using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{ 
    public class GetContainerDetailsResult_
    {
        public List<ContainerDetails> GetContainerDetailsResult { get; set; }
    }

    public class GetContainerDetailsxManifiestoIdResult_
    {
        public List<ContainerDetails> GetContainerDetailsxManifiestoIdResult { get; set; }
    }

    public class ContainerDetails
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
        public string fechaEmbarcado { get; set; }        
        public string UsuarioEmbarcado { get; set; }
        public string ManifiestoId { get; set; }
        public string NoDocumento { get; set; }
        public string Solicitante { get; set; }
        public string FechaSolicitud { get; set; }
        public string codigoTipoManifiesto { get; set; }
        public string tipoManifiesto { get; set; }
        public string codigoTipoResiduo { get; set; }
        public string tipoResiduo { get; set; }
        public string Generador { get; set; }
        public string GeneradorDesc { get; set; }
        public string Transportista { get; set; }
        public string TransportistaDesc { get; set; }
        public string Destinatario { get; set; }
        public string DestinatarioDesc { get; set; }
        public string numFactura { get; set; }
        public string numShipping { get; set; }
        public string EstatusGaylord { get; set; }
        public string EstatusGaylordDesc { get; set; }
        public string EstatusManifiesto { get; set; }
        public string EstatusManifiestoDesc { get; set; }
        public string etiqueta { get; set; }        
        public string expira { get; set; }        
        public string tiempoExpiracion { get; set; }
        public string FechaExpiracion { get; set; }

        public string Actions
        {
            get { return "0"; }
        }
    }
}