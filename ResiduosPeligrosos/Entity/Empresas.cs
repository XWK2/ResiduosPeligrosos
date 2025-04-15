using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetEmpresasResult_
    {
        public List<Empresas> GetEmpresasResult { get; set; }
    }
    public class GetCmbEmpresasResult_
    {
        public List<Empresas> GetCmbEmpresasResult { get; set; }
    }

    public class DelEmpresasResult_
    {
        public int DelEmpresasResult { get; set; }
    }
    public class InsEmpresasResult_
    {
        public int InsEmpresasResult { get; set; }
    }
    public class UpdEmpresasResult_
    {
        public int UpdEmpresasResult { get; set; }
    }
    public class ValEmpresasResult_
    {
        public int ValEmpresasResult { get; set; }
    }
    public class DelEmpresasSelectedResult_
    {
        public int DelEmpresasSelectedResult { get; set; }
    }
    public class DelEmpresasAllResult_
    {
        public int DelEmpresasAllResult { get; set; }
    }

    public class Empresas
    {
        public int EmpresaId { get; set; }
        public string codigoEmpresa { get; set; }
        public string TipoEmpresa { get; set; }
        public string NoRegistroAmbiental { get; set; }
        public string RazonSocial { get; set; }
        public string RFC { get; set; }
        public string CodigoPostal { get; set; }
        public string Calle { get; set; }
        public string NoExterior { get; set; }
        public string NoInterior { get; set; }
        public string Colonia { get; set; }
        public string Municipio { get; set; }
        public string Estado { get; set; }
        public string Telefono { get; set; }
        public string NoAutorizacionSEMARNAT { get; set; }
        public string NoPermisoSCT { get; set; }
        public string CodigoTipoVehiculo { get; set; }
        public string TipoVehiculo { get; set; }
        public string Placas { get; set; }
        public string Rutas { get; set; }
        public string Responsable { get; set; }
        public string OpcionDefault { get; set; }
        public string otrosdatos { get; set; }
    }
}