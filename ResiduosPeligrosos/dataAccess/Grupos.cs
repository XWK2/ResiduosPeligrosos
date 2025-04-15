using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class GruposDa : Base
    {
        public List<Entity.Grupos> GetCatalog(string Codigo, string Descripcion, bool Activo)
        {
            string json = methodGet("GetGrupos/" + Codigo + "/" + Descripcion + "/" + Activo.ToString());
            Entity.GetGruposResult_ regreso = JsonConvert.DeserializeObject<Entity.GetGruposResult_>(json);
            return regreso.GetGruposResult;
        }

        public List<Entity.Grupos> GetCmbGruposbyTipoManifiesto(string TipoManifiesto, bool Activo)
        {
            string json = methodGet("GetCmbGruposbyTipoManifiesto/" + TipoManifiesto + "/" + Activo.ToString());
            Entity.GetCmbGruposbyTipoManifiestoResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbGruposbyTipoManifiestoResult_>(json);
            return regreso.GetCmbGruposbyTipoManifiestoResult;
        }

        public List<Entity.Grupos> GetCombo()
        {
            string json = methodGet("GetCmbGrupos");
            Entity.GetCmbGruposResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbGruposResult_>(json);
            return regreso.GetCmbGruposResult;
        }
             

        public int InsGrupos(int IdUser, string Codigo, string Nombre)
        {
            Entity.Grupos util = new Entity.Grupos();
            util.codigo = Codigo;
            util.nombre = Nombre;

            Entity.InsGruposResult_ regreso = JsonConvert.DeserializeObject<Entity.InsGruposResult_>(methodPost("InsGrupos/" + IdUser.ToString(), JsonConvert.SerializeObject(util)));
            return regreso.InsGruposResult;
        }

        public int UpdGrupos(int IdUser, int GrupoId, string Codigo, string Nombre)
        {
            Entity.Grupos util = new Entity.Grupos();
            util.grupoId = GrupoId;
            util.codigo = Codigo;
            util.nombre = Nombre;

            Entity.UpdGruposResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdGruposResult_>(methodPost("UpdGrupos/" + IdUser.ToString(), JsonConvert.SerializeObject(util)));
            return regreso.UpdGruposResult;
        }

        public int ValGrupos(int IdGrupos, string Codigo, string Descripcion)
        {
            Entity.ValGruposResult_ regreso = JsonConvert.DeserializeObject<Entity.ValGruposResult_>(methodPost("ValGrupos/" + IdGrupos.ToString() + "/" + Codigo + "/" + Descripcion));
            return regreso.ValGruposResult;
        }

        public int DelGruposSelected(int IdUser, string Valores)
        {
            Entity.DelGruposSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelGruposSelectedResult_>(methodPost("DelGruposSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelGruposSelectedResult;
        }

        public int DelGruposAll(int IdUser, bool Activo)
        {
            Entity.DelGruposAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelGruposAllResult_>(methodPost("DelGruposAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelGruposAllResult;
        }
    }
}