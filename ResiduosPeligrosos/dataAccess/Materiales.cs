using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class MaterialesDa : Base
    {
        public List<Entity.Materiales> GetCatalog(string Codigo, string Descripcion, bool Activo)
        {
            string json = methodGet("GetMateriales/" + Codigo + "/" + Descripcion + "/" + Activo.ToString());
            Entity.GetMaterialesResult_ regreso = JsonConvert.DeserializeObject<Entity.GetMaterialesResult_>(json);
            return regreso.GetMaterialesResult;
        }

        public List<Entity.Materiales> GetCombo()
        {
            string json = methodGet("GetCmbMateriales");
            Entity.GetCmbMaterialesResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbMaterialesResult_>(json);
            return regreso.GetCmbMaterialesResult;
        }

        public int DelMateriales(int IdUser, int IdMateriales)
        {
            Entity.DelMaterialesResult_ regreso = JsonConvert.DeserializeObject<Entity.DelMaterialesResult_>(methodPost("DelMateriales/" + IdUser.ToString() + "/" + IdMateriales.ToString()));
            return regreso.DelMaterialesResult;
        }

        public int InsMateriales(int IdUser, string Codigo, string Nombre,string pais, string cveSat, decimal precioU, string nameEnglish)
        {
            Entity.Materiales maq = new Entity.Materiales();
            maq.Codigo = Codigo;
            maq.Nombre = Nombre;
            maq.pais = pais;
            maq.cveSat = cveSat;
            maq.precioU = precioU;
            maq.nameEnglish = nameEnglish;

            Entity.InsMaterialesResult_ regreso = JsonConvert.DeserializeObject<Entity.InsMaterialesResult_>(methodPost("InsMateriales/" + IdUser.ToString(), JsonConvert.SerializeObject(maq)));
            return regreso.InsMaterialesResult;
        }

        public int UpdMateriales(int IdUser, int MaterialId, string Codigo, string Nombre, string pais, string cveSat, decimal precioU, string nameEnglish)
        {
            Entity.Materiales maq = new Entity.Materiales();
            maq.MaterialId = MaterialId;
            maq.Codigo = Codigo;
            maq.Nombre = Nombre;
            maq.pais = pais;
            maq.cveSat = cveSat;
            maq.precioU = precioU;
            maq.nameEnglish = nameEnglish;

            Entity.UpdMaterialesResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdMaterialesResult_>(methodPost("UpdMateriales/" + IdUser.ToString(), JsonConvert.SerializeObject(maq)));
            return regreso.UpdMaterialesResult;
        }

        public int ValMateriales(int MaterialId, string Codigo, string Descripcion)
        {
            Entity.ValMaterialesResult_ regreso = JsonConvert.DeserializeObject<Entity.ValMaterialesResult_>(methodPost("ValMateriales/" + MaterialId.ToString() + "/" + Codigo + "/" + Descripcion));
            return regreso.ValMaterialesResult;
        }

        public int DelMaterialesSelected(int IdUser, string Valores)
        {
            Entity.DelMaterialesSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelMaterialesSelectedResult_>(methodPost("DelMaterialesSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelMaterialesSelectedResult;
        }

        public int DelMaterialesAll(int IdUser, bool Activo)
        {
            Entity.DelMaterialesAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelMaterialesAllResult_>(methodPost("DelMaterialesAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelMaterialesAllResult;
        }
    }
}