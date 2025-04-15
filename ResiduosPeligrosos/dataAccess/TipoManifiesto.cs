using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class TipoManifiestoDa : Base
    {
        public List<Entity.TipoManifiesto> GetCatalog(string Codigo, string Descripcion, bool Activo)
        {
            string json = methodGet("GetTipoManifiesto/" + Codigo + "/" + Descripcion + "/" + Activo.ToString());
            Entity.GetTipoManifiestoResult_ regreso = JsonConvert.DeserializeObject<Entity.GetTipoManifiestoResult_>(json);
            return regreso.GetTipoManifiestoResult;
        }

        public List<Entity.TipoManifiesto> GetCombo()
        {
            string json = methodGet("GetCmbTipoManifiesto");
            Entity.GetCmbTipoManifiestoResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbTipoManifiestoResult_>(json);
            return regreso.GetCmbTipoManifiestoResult;
        }

        public int DelTipoManifiesto(int IdUser, int IdTipoManifiesto)
        {
            Entity.DelTipoManifiestoResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoManifiestoResult_>(methodPost("DelTipoManifiesto/" + IdUser.ToString() + "/" + IdTipoManifiesto.ToString()));
            return regreso.DelTipoManifiestoResult;
        }

        public int InsTipoManifiesto(int IdUser, string Codigo, string Nombre, string CodigoTipoMaterial)
        {
            Entity.TipoManifiesto tipoManifiesto = new Entity.TipoManifiesto();
            tipoManifiesto.Codigo = Codigo;
            tipoManifiesto.Nombre = Nombre;
            tipoManifiesto.CodigoTipoMaterial = CodigoTipoMaterial;

            Entity.InsTipoManifiestoResult_ regreso = JsonConvert.DeserializeObject<Entity.InsTipoManifiestoResult_>(methodPost("InsTipoManifiesto/" + IdUser.ToString(), JsonConvert.SerializeObject(tipoManifiesto)));
            return regreso.InsTipoManifiestoResult;
        }

        public int UpdTipoManifiesto(int IdUser, int TipoManifiestoId, string Codigo, string Nombre, string CodigoTipoMaterial)
        {
            Entity.TipoManifiesto tipoManifiesto = new Entity.TipoManifiesto();
            tipoManifiesto.TipoManifiestoId = TipoManifiestoId;
            tipoManifiesto.Codigo = Codigo;
            tipoManifiesto.Nombre = Nombre;
            tipoManifiesto.CodigoTipoMaterial = CodigoTipoMaterial;

            Entity.UpdTipoManifiestoResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdTipoManifiestoResult_>(methodPost("UpdTipoManifiesto/" + IdUser.ToString(), JsonConvert.SerializeObject(tipoManifiesto)));
            return regreso.UpdTipoManifiestoResult;
        }

        public int ValTipoManifiesto(int IdTipoManifiesto, string Codigo, string Descripcion)
        {
            Entity.ValTipoManifiestoResult_ regreso = JsonConvert.DeserializeObject<Entity.ValTipoManifiestoResult_>(methodPost("ValTipoManifiesto/" + IdTipoManifiesto.ToString() + "/" + Codigo + "/" + Descripcion));
            return regreso.ValTipoManifiestoResult;
        }

        public int DelTipoManifiestoSelected(int IdUser, string Valores)
        {
            Entity.DelTipoManifiestoSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoManifiestoSelectedResult_>(methodPost("DelTipoManifiestoSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelTipoManifiestoSelectedResult;
        }

        public int DelTipoManifiestoAll(int IdUser, bool Activo)
        {
            Entity.DelTipoManifiestoAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoManifiestoAllResult_>(methodPost("DelTipoManifiestoAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelTipoManifiestoAllResult;
        }
    }
}