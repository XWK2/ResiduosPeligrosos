using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class TiposEnvaseDa : Base
    {
        public List<Entity.TiposEnvase> GetCatalog(string Codigo, bool Activo)
        {
            string json = methodGet("GetTipoEnvase/" + Codigo + "/" + Activo.ToString());
            Entity.GetTipoEnvaseResult_ regreso = JsonConvert.DeserializeObject<Entity.GetTipoEnvaseResult_>(json);
            return regreso.GetTipoEnvaseResult;
        }

        public List<Entity.TiposEnvase> GetCombo()
        {
            string json = methodGet("GetCmbTiposEnvase");
            Entity.GetCmbTiposEnvaseResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbTiposEnvaseResult_>(json);
            return regreso.GetCmbTiposEnvaseResult;
        }
  

        public int DelTipoEnvase(int IdUser, int IdTipoEnvase)
        {
            Entity.DelTiposEnvaseResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTiposEnvaseResult_>(methodPost("DelTiposEnvase/" + IdUser.ToString() + "/" + IdTipoEnvase.ToString()));
            return regreso.DelTiposEnvaseResult;
        }

        public int InsTipoEnvase(int IdUser, string Codigo, decimal capacidad, string material, decimal pesoBruto)
        {
            Entity.TiposEnvase tEnvase = new Entity.TiposEnvase();
            tEnvase.Codigo = Codigo;
            tEnvase.capacidad = capacidad;
            tEnvase.material = material;
            tEnvase.pesoBruto = pesoBruto;


            Entity.InsTiposEnvaseResult_ regreso = JsonConvert.DeserializeObject<Entity.InsTiposEnvaseResult_>(methodPost("InsTiposEnvase/" + IdUser.ToString(), JsonConvert.SerializeObject(tEnvase)));
            return regreso.InsTiposEnvaseResult;
        }

        public int UpdTipoEnvase(int IdUser, int id_tipoEnvase, string Codigo, decimal capacidad, string material, decimal pesoBruto)
        {
            Entity.TiposEnvase tEnvase = new Entity.TiposEnvase();
            tEnvase.tipoEnvaseID = id_tipoEnvase;
            tEnvase.Codigo = Codigo;
            tEnvase.capacidad = capacidad;
            tEnvase.material = material;
            tEnvase.pesoBruto = pesoBruto;

            Entity.UpdTiposEnvaseResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdTiposEnvaseResult_>(methodPost("UpdTiposEnvase/" + IdUser.ToString(), JsonConvert.SerializeObject(tEnvase)));
            return regreso.UpdTiposEnvaseResult;
        }

        public int ValTipoEnvase(int id_tipoEnvase, string Codigo)
        {
            Entity.ValTiposEnvaseResult_ regreso = JsonConvert.DeserializeObject<Entity.ValTiposEnvaseResult_>(methodPost("ValTiposEnvase/" + id_tipoEnvase.ToString() + "/" + Codigo));
            return regreso.ValTiposEnvaseResult;
        }

        public int DelTipoEnvaseSelected(int IdUser, string Valores)
        {
            Entity.DelTiposEnvaseSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTiposEnvaseSelectedResult_>(methodPost("DelTiposEnvaseSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelTiposEnvaseSelectedResult;
        }

        public int DelTipoEnvaseAll(int IdUser, bool Activo)
        {
            Entity.DelTiposEnvaseAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTiposEnvaseAllResult_>(methodPost("DelTiposEnvaseAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelTiposEnvaseAllResult;
        }
    }
}