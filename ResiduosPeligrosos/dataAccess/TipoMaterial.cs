using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class TipoMaterialDa : Base
    {
        public List<Entity.TipoMaterial> GetCatalog(string Codigo, string Descripcion, bool Activo)
        {
            string json = methodGet("GetTipoMaterial/" + Codigo + "/" + Descripcion + "/" + Activo.ToString());
            Entity.GetTipoMaterialResult_ regreso = JsonConvert.DeserializeObject<Entity.GetTipoMaterialResult_>(json);
            return regreso.GetTipoMaterialResult;
        }

        public List<Entity.TipoMaterial> GetCombo()
        {
            string json = methodGet("GetCmbTipoMaterial");
            Entity.GetCmbTipoMaterialResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbTipoMaterialResult_>(json);
            return regreso.GetCmbTipoMaterialResult;
        }

        public int DelTipoMaterial(int IdUser, int IdTipoMaterial)
        {
            Entity.DelTipoMaterialResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoMaterialResult_>(methodPost("DelTipoMaterial/" + IdUser.ToString() + "/" + IdTipoMaterial.ToString()));
            return regreso.DelTipoMaterialResult;
        }

        public int InsTipoMaterial(int IdUser, string Codigo, string Nombre)
        {
            Entity.TipoMaterial maq = new Entity.TipoMaterial();
            maq.Codigo = Codigo;
            maq.Nombre = Nombre;

            Entity.InsTipoMaterialResult_ regreso = JsonConvert.DeserializeObject<Entity.InsTipoMaterialResult_>(methodPost("InsTipoMaterial/" + IdUser.ToString(), JsonConvert.SerializeObject(maq)));
            return regreso.InsTipoMaterialResult;
        }

        public int UpdTipoMaterial(int IdUser, int TipoMaterialId, string Codigo, string Nombre)
        {
            Entity.TipoMaterial maq = new Entity.TipoMaterial();
            maq.TipoMaterialID = TipoMaterialId;
            maq.Codigo = Codigo;
            maq.Nombre = Nombre;

            Entity.UpdTipoMaterialResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdTipoMaterialResult_>(methodPost("UpdTipoMaterial/" + IdUser.ToString(), JsonConvert.SerializeObject(maq)));
            return regreso.UpdTipoMaterialResult;
        }

        public int ValTipoMaterial(int IdTipoMaterial, string Codigo, string Descripcion)
        {
            Entity.ValTipoMaterialResult_ regreso = JsonConvert.DeserializeObject<Entity.ValTipoMaterialResult_>(methodPost("ValTipoMaterial/" + IdTipoMaterial.ToString() + "/" + Codigo + "/" + Descripcion));
            return regreso.ValTipoMaterialResult;
        }

        public int DelTipoMaterialSelected(int IdUser, string Valores)
        {
            Entity.DelTipoMaterialSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoMaterialSelectedResult_>(methodPost("DelTipoMaterialSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelTipoMaterialSelectedResult;
        }

        public int DelTipoMaterialAll(int IdUser, bool Activo)
        {
            Entity.DelTipoMaterialAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelTipoMaterialAllResult_>(methodPost("DelTipoMaterialAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelTipoMaterialAllResult;
        }
    }
}