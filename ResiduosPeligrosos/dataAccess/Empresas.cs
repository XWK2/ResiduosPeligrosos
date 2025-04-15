using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;


namespace ResiduosPeligrosos.dataAccess
{   
    public class EmpresasDa: Base
    {

        public List<Entity.Empresas> GetCatalog(string Codigo, string TipoEmpresa, bool Activo)
        {
            string json = methodGet("GetEmpresas/" + Codigo + "/" + TipoEmpresa + "/" +  Activo.ToString());
            Entity.GetEmpresasResult_ regreso = JsonConvert.DeserializeObject<Entity.GetEmpresasResult_>(json);
            return regreso.GetEmpresasResult;
        }

        public List<Entity.Empresas> GetCombo()
        {
            string json = methodGet("GetCmbEmpresas");
            Entity.GetCmbEmpresasResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbEmpresasResult_>(json);
            return regreso.GetCmbEmpresasResult;
        }
        
        public int InsEmpresas(int IdUser, string codigoEmpresa, string TipoEmpresa, string NoRegistroAmbiental, string RazonSocial, string RFC, string CodigoPostal, string Calle, string NoExterior, string NoInterior, string Colonia, string Municipio, string Estado, string Telefono, string NoAutorizacionSEMARNAT, string NoPermisoSCT, string Responsable, string OpcionDefault, string otrosdatos)
        {
            Entity.Empresas tEmpresas = new Entity.Empresas();            
            tEmpresas.codigoEmpresa= codigoEmpresa;
            tEmpresas.TipoEmpresa= TipoEmpresa;
            tEmpresas.NoRegistroAmbiental= NoRegistroAmbiental;
            tEmpresas.RazonSocial= RazonSocial;
            tEmpresas.RFC= RFC;
            tEmpresas.CodigoPostal= CodigoPostal;
            tEmpresas.Calle= Calle;
            tEmpresas.NoExterior= NoExterior;
            tEmpresas.NoInterior= NoInterior;
            tEmpresas.Colonia= Colonia;
            tEmpresas.Municipio= Municipio;
            tEmpresas.Estado= Estado;
            tEmpresas.Telefono= Telefono;
            tEmpresas.NoAutorizacionSEMARNAT= NoAutorizacionSEMARNAT;
            tEmpresas.NoPermisoSCT= NoPermisoSCT;                    
            tEmpresas.Responsable= Responsable;            
            tEmpresas.OpcionDefault = OpcionDefault;
            tEmpresas.otrosdatos = otrosdatos;

        Entity.InsEmpresasResult_ regreso = JsonConvert.DeserializeObject<Entity.InsEmpresasResult_>(methodPost("InsertEmpresas/" + IdUser.ToString(), JsonConvert.SerializeObject(tEmpresas)));
            return regreso.InsEmpresasResult;
        }

        public int UpdEmpresas(int EmpresaId, int IdUser, string codigoEmpresa, string TipoEmpresa, string NoRegistroAmbiental, string RazonSocial, string RFC, string CodigoPostal, string Calle, string NoExterior, string NoInterior, string Colonia, string Municipio, string Estado, string Telefono, string NoAutorizacionSEMARNAT, string NoPermisoSCT, string Responsable, string OpcionDefault, string otrosdatos)
        {
            Entity.Empresas tEmpresas = new Entity.Empresas();
            tEmpresas.EmpresaId = EmpresaId;
            tEmpresas.codigoEmpresa = codigoEmpresa;
            tEmpresas.TipoEmpresa = TipoEmpresa;
            tEmpresas.NoRegistroAmbiental = NoRegistroAmbiental;
            tEmpresas.RazonSocial = RazonSocial;
            tEmpresas.RFC = RFC;
            tEmpresas.CodigoPostal = CodigoPostal;
            tEmpresas.Calle = Calle;
            tEmpresas.NoExterior = NoExterior;
            tEmpresas.NoInterior = NoInterior;
            tEmpresas.Colonia = Colonia;
            tEmpresas.Municipio = Municipio;
            tEmpresas.Estado = Estado;
            tEmpresas.Telefono = Telefono;
            tEmpresas.NoAutorizacionSEMARNAT = NoAutorizacionSEMARNAT;
            tEmpresas.NoPermisoSCT = NoPermisoSCT;            
            tEmpresas.Responsable = Responsable;            
            tEmpresas.OpcionDefault = OpcionDefault;
            tEmpresas.otrosdatos = otrosdatos;

            Entity.UpdEmpresasResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdEmpresasResult_>(methodPost("UpdateEmpresas/" + IdUser.ToString(), JsonConvert.SerializeObject(tEmpresas)));
            return regreso.UpdEmpresasResult;
        }

        public int ValEmpresas(int EmpresaId, string Codigo, string TipoEmpresa)
        {
            Entity.ValEmpresasResult_ regreso = JsonConvert.DeserializeObject<Entity.ValEmpresasResult_>(methodPost("ValEmpresas/" + EmpresaId.ToString() + "/" + Codigo + "/" + TipoEmpresa));
            return regreso.ValEmpresasResult;
        }

        public int DelEmpresasSelected(int IdUser, string Valores)
        {
            Entity.DelEmpresasSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelEmpresasSelectedResult_>(methodPost("DelEmpresasSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelEmpresasSelectedResult;
        }

        public int DelEmpresasAll(int IdUser, bool Activo)
        {
            Entity.DelEmpresasAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelEmpresasAllResult_>(methodPost("DelEmpresasAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelEmpresasAllResult;
        }
    }
}