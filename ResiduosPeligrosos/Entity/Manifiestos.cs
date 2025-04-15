using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetManifiestosResult_
    {
        public List<Manifiestos> GetManifiestosResult { get; set; }
    }

    public class GetManifiestoResult_
    {
        public List<Manifiestos> GetManifiestoResult { get; set; }
    }

    public class GetConsecutivosolicitudResult_
    {
        public string GetConsecutivosolicitudResult { get; set; }
    }    

    public class InsManifiestoResult_
    {
        public int InsManifiestoResult { get; set; }
    }

    public class UpdManifiestoResult_
    {
        public int UpdManifiestoResult { get; set; }
    }

    public class Manifiestos
    {
        public int ManifiestoId { get; set; }
        public string numManifiesto { get; set; }
        public string numFactura { get; set; }
        public string numShipping { get; set; }
        public string autor { get; set; }
        public string fecha { get; set; }
        public string planta { get; set; }
        public string tipoManifiesto { get; set; }
        public string tipoManifiestoDesc { get; set; }  //OK
        public string tipoResiduo { get; set; }
        public string tipoResiduoDesc { get; set; }     //OK
        public string numRegistroAmbiental { get; set; }
        public string numRegistroAmbientalDesc { get; set; }  //OK
        public int paginaNumero { get; set; }
        public string nombreGenerador { get; set; }
        public string nombreGeneradorDesc { get; set; }  //OK
        public string cpGen { get; set; }
        public string direccion { get; set; }
        public string numeroExterior { get; set; }
        public string numeroInterior { get; set; }
        public string colonia { get; set; }
        public string municipio { get; set; }
        public string estado { get; set; }
        public string tel { get; set; }
        public string correoElectronico { get; set; }
        public string instrucciones { get; set; }
        public string responsable { get; set; }
        public string fechaGenerador { get; set; }
        public string nombreTransportista { get; set; }  
        public string nombreTransportistaDesc { get; set; } //OK
        public string cpTrans { get; set; }
        public string direccionTrans { get; set; }
        public string numeroExteriorTrans { get; set; }
        public string numeroInteriorTrans { get; set; }
        public string coloniaTrans { get; set; }
        public string municipioTrans { get; set; }
        public string estadoTrans { get; set; }
        public string telTrans { get; set; }
        public string correoElectronicoTrans { get; set; }
        public string numeroAutorizacionSemarnatTrans { get; set; }
        public string numeroPermisoSCTTrans { get; set; }
        public string tipoVehiculoTrans { get; set; }
        public string placasTrans { get; set; }
        public string rutaEmpresaTrans { get; set; }
        public string responsableTrans { get; set; }
        public string fechaTrans { get; set; }
        public string nombreDestinatario { get; set; }
        public string nombreDestinatarioDesc { get; set; }    //OK
        public string cpDes { get; set; }
        public string direccionDes { get; set; }
        public string numeroExteriorDes { get; set; }
        public string numeroInteriorDes { get; set; }
        public string coloniaDes { get; set; }
        public string municipioDes { get; set; }
        public string estadoDes { get; set; }
        public string telDes { get; set; }
        public string correoElectronicoDes { get; set; }
        public string numeroAutorizacionSemarnatDes { get; set; }
        public string nomnbrePersonaRecibeDes { get; set; }
        public string responsableDes { get; set; }
        public string fechaDes { get; set; }
        public string codigoEstatus { get; set; }
        public string estatus { get; set; }
        public int contenedores { get; set; }

        public string @esVenta { get; set; }
        public string codigoMoneda { get; set; }
        public string estatusPago { get; set; }

        public List<_Gaylords> gaylords { get; set; }
        public List<Aprobacion> aprobaciones { get; set; }
        public List<historial> historial { get; set; }

        public string Actions
        {
            get { return "0"; }
        }

        public string ModFecha { get; set; }
        public string fechaSolicitud { get; set; }
        public string usuario { get; set; }
        public string codigo_sts_Prods { get; set; }
    }

    public class _Residuos
    {        
        public string NoDocumento { get; set; }
        public int ResiduoId { get; set; }        
        public string CodigoResiduo { get; set; }        
        public string Nombre { get; set; }        
        public string Clasificaciones { get; set; }        
        public string CodigoTipoManifiesto { get; set; }        
        public string TipoManifiesto { get; set; }        
        public string CodigoGrupo { get; set; }        
        public string Grupo { get; set; }        
        public string ValorizableConBeneficio { get; set; }        
        public string ValorizableConGasto { get; set; }        
        public string Tipo { get; set; }
    }

    public class _Gaylords {
        public string noDocumento { get; set; }
        public int GaylordID { get; set; }        
        public string codigo { get; set; }        
        public string codigoTipoEnvase { get; set; }      
        public string codigoMaterial { get; set; }      
        public string codigoLocacion { get; set; }      
        public decimal capacidad { get; set; }      
        public string Material { get; set; }      
        public string locacion { get; set; }      
        public string TipoEnvase { get; set; }
        public string clasificaciones { get; set; }
        public string IEDescripcion { get; set; }
        public string residuo { get; set; }
        public decimal peso { get; set; }
    }

    public class Aprobacion
    {
        public int AprobacionesID { get; set; }
        public string noDocumento { get; set; }
        public string codigoAprobaciones { get; set; }
        public string paso { get; set; }
        public string titulo { get; set; }
        public string codigoEmpleado { get; set; }
        public string usuario { get; set; }
        public string puesto { get; set; }
        public string fechaNotificacion { get; set; }
        public string fechaAccion { get; set; }
        public string accion { get; set; }
        public string comentario { get; set; }
    }

    public class historial
    {
        public string numManifiesto { get; set; }
        public string fecha { get; set; }
        public string accion { get; set; }
        public string comentarios { get; set; }
        public string codigoEmpleado { get; set; }
        public string NombreCompleto { get; set; }
    }
    public class Unico
    {
        public bool value { get; set; }
        public string text { get; set; }
    }
}