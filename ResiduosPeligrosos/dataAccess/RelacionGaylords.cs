using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;
using System.Data;


namespace ResiduosPeligrosos.dataAccess
{
    public class RelacionGaylordsDa : Base
    {
        public List<Entity.RelacionGaylords> GetRelacionGaylords(string CodigoParte, string CodigoTipoEnvase, bool Activo)
        {          

            string json = methodGet("GetRelacionGaylords/" + CodigoParte + "/" + CodigoTipoEnvase +  "/" + Activo.ToString());
            Entity.GetRelacionGaylordsResult_ regreso = JsonConvert.DeserializeObject<Entity.GetRelacionGaylordsResult_>(json);
            return regreso.GetRelacionGaylordsResult;
        }

        public List<Entity.RelacionGaylords> GetCmbRelacionGaylords()
        {
            string json = methodGet("GetCmbRelacionGaylords");
            Entity.GetCmbRelacionGaylordsResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbRelacionGaylordsResult_>(json);
            return regreso.GetCmbRelacionGaylordsResult;
        }
        public int InsertRelacionGaylords(string CodigoParte, string numParteImportExport,string CodigoResiduo, string CodigoTipoEnvase,string expira, int tiempoExpiracion, string venta, string etiqueta, int UsuarioId)
        {
            Entity.RelacionGaylords tRel = new Entity.RelacionGaylords();
            tRel.CodigoParte= CodigoParte;
            tRel.numParteImportExport = numParteImportExport;
            tRel.CodigoResiduo = CodigoResiduo;          
            tRel.CodigoTipoEnvase = CodigoTipoEnvase;
            tRel.expira = expira;
            tRel.tiempoExpiracion = tiempoExpiracion;
            tRel.venta = venta;
            tRel.etiqueta = etiqueta;
            tRel.Parte = "";
            tRel.Residuo = "";
            tRel.TipoEnvase = "";

            Entity.InsRelacionGaylordsResult_ regreso = JsonConvert.DeserializeObject<Entity.InsRelacionGaylordsResult_>(methodPost("InsertRelacionGaylords/" + UsuarioId.ToString(), JsonConvert.SerializeObject(tRel)));
            return regreso.InsRelacionGaylordsResult;
        }
        public int UpdateRelacionGaylords(int RelacionId, string CodigoParte, string numParteImportExport, string CodigoResiduo, string CodigoTipoEnvase, string expira, int tiempoExpiracion, string venta, string etiqueta, int UsuarioId)
        {            
            Entity.RelacionGaylords tRel = new Entity.RelacionGaylords();
            tRel.RelacionId = RelacionId;
            tRel.CodigoResiduo = CodigoResiduo;
            tRel.CodigoParte = CodigoParte;
            tRel.numParteImportExport = numParteImportExport;            
            tRel.CodigoTipoEnvase = CodigoTipoEnvase;
            tRel.expira = expira;
            tRel.tiempoExpiracion = tiempoExpiracion;
            tRel.venta = venta;
            tRel.etiqueta = etiqueta;
            tRel.Parte = "";
            tRel.Residuo = "";
            tRel.TipoEnvase = "";

            Entity.UpdRelacionGaylordsResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdRelacionGaylordsResult_>(methodPost("UpdateRelacionGaylords/" + UsuarioId.ToString(), JsonConvert.SerializeObject(tRel)));
            return regreso.UpdRelacionGaylordsResult;
        }

        public int ValRelacionGaylords(int RegistroId, string CodigoParte, string numParteImportExport, string CodigoResiduo, string CodigoTipoEnvase)
        {
            return Convert.ToInt32(methodPost("ValRelacionGaylords/" + RegistroId.ToString() + "/" + CodigoParte + "/" + numParteImportExport + "/" + CodigoResiduo + "/" + CodigoTipoEnvase));
        }

        public int DelRelacionGaylordsSelected(int UsuarioId, string Valores)
        {
            Entity.DelRelacionGaylordsSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelRelacionGaylordsSelectedResult_>(methodPost("DelRelacionGaylordsSelected/" + UsuarioId.ToString() + "/" + Valores));
            return regreso.DelRelacionGaylordsSelectedResult;
        }

        public int DelRelacionGaylordsAll(int UsuarioId, bool Activo)
        {
            Entity.DelRelacionGaylordsAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelRelacionGaylordsAllResult_>(methodPost("DelRelacionGaylordsAll/" + UsuarioId.ToString() + "/" + Activo.ToString()));
            return regreso.DelRelacionGaylordsAllResult;
        }
    }
}