using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.dataAccess
{
    public class LocacionesDa : Base
    {
        public List<Entity.Locaciones> GetCatalog(string Codigo, bool Activo)
        {
            string json = methodGet("GetLocaciones/" + Codigo + "/" + Activo.ToString());
            Entity.GetLocacionesResult_ regreso = JsonConvert.DeserializeObject<Entity.GetLocacionesResult_>(json);
            return regreso.GetLocacionesResult;
        }

        public List<Entity.Locaciones> GetCombo()
        {
            string json = methodGet("GetCmbLocacion");
            Entity.GetCmbLocacionResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbLocacionResult_>(json);
            return regreso.GetCmbLocacionResult;
        }

        public List<Entity.Locaciones> GetCmbLocacionbyalmacen(string CodigoAlmacen)
        {
            string json = methodGet("GetCmbLocacionbyalmacen/" + CodigoAlmacen);
            Entity.GetCmbLocacionbyalmacenResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbLocacionbyalmacenResult_>(json);
            return regreso.GetCmbLocacionbyalmacenResult;
        }        

        public int DelLocaciones(int IdUser, int IdLocaciones)
        {
            Entity.DelLocacionesResult_ regreso = JsonConvert.DeserializeObject<Entity.DelLocacionesResult_>(methodPost("DelLocaciones/" + IdUser.ToString() + "/" + IdLocaciones.ToString()));
            return regreso.DelLocacionesResult;
        }

        public int InsLocaciones(int IdUser, string Codigo, string nombreLocacion, string codigoAlmacen)
        {
            Entity.Locaciones tLocaciones = new Entity.Locaciones();
            tLocaciones.Codigo = Codigo;
            tLocaciones.nombreLocacion = nombreLocacion;
            tLocaciones.codigoAlmacen = codigoAlmacen;

            Entity.InsLocacionesResult_ regreso = JsonConvert.DeserializeObject<Entity.InsLocacionesResult_>(methodPost("InsLocaciones/" + IdUser.ToString(), JsonConvert.SerializeObject(tLocaciones)));
            return regreso.InsLocacionesResult;
        }

        public int UpdLocaciones(int IdUser, int locacionId, string Codigo, string nombreLocacion, string codigoAlmacen)
        {
            Entity.Locaciones tLocaciones = new Entity.Locaciones();
            tLocaciones.locacionId = locacionId;
            tLocaciones.Codigo = Codigo;
            tLocaciones.nombreLocacion = nombreLocacion;
            tLocaciones.codigoAlmacen = codigoAlmacen;

            Entity.UpdLocacionesResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdLocacionesResult_>(methodPost("UpdLocaciones/" + IdUser.ToString(), JsonConvert.SerializeObject(tLocaciones)));
            return regreso.UpdLocacionesResult;
        }

        public int ValLocaciones(int idLocaciones, string Codigo)
        {
            Entity.ValLocacionesResult_ regreso = JsonConvert.DeserializeObject<Entity.ValLocacionesResult_>(methodPost("ValLocaciones/" + idLocaciones.ToString() + "/" + Codigo));
            return regreso.ValLocacionesResult;
        }

        public int DelLocacionesSelected(int IdUser, string Valores)
        {
            Entity.DelLocacionesSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelLocacionesSelectedResult_>(methodPost("DelLocacionesSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelLocacionesSelectedResult;
        }

        public int DelLocacionesAll(int IdUser, bool Activo)
        {
            Entity.DelLocacionesAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelLocacionesAllResult_>(methodPost("DelLocacionesAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelLocacionesAllResult;
        }
    }
}