using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class ClasificacionDa : Base
    {
        public List<Entity.Clasificacion> GetCatalog(string Codigo, string Descripcion, bool Activo)
        {
            string json = methodGet("GetClasificacion/" + Codigo + "/" + Descripcion + "/" + Activo.ToString());
            Entity.GetClasificacionResult_ regreso = JsonConvert.DeserializeObject<Entity.GetClasificacionResult_>(json);
            return regreso.GetClasificacionResult;
        }

        public List<Entity.Clasificacion> GetCombo()
        {
            string json = methodGet("GetCmbClasificacion");
            Entity.GetCmbClasificacionResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbClasificacionResult_>(json);
            return regreso.GetCmbClasificacionResult;
        }
             

        public int InsClasificacion(int IdUser, string Codigo, string Nombre)
        {
            Entity.Clasificacion util = new Entity.Clasificacion();
            util.codigo = Codigo;
            util.nombre = Nombre;

            Entity.InsClasificacionResult_ regreso = JsonConvert.DeserializeObject<Entity.InsClasificacionResult_>(methodPost("InsClasificacion/" + IdUser.ToString(), JsonConvert.SerializeObject(util)));
            return regreso.InsClasificacionResult;
        }

        public int UpdClasificacion(int IdUser, int ClasificacionId, string Codigo, string Nombre)
        {
            Entity.Clasificacion util = new Entity.Clasificacion();
            util.clasificacionId = ClasificacionId;
            util.codigo = Codigo;
            util.nombre = Nombre;

            Entity.UpdClasificacionResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdClasificacionResult_>(methodPost("UpdClasificacion/" + IdUser.ToString(), JsonConvert.SerializeObject(util)));
            return regreso.UpdClasificacionResult;
        }

        public int ValClasificacion(int IdClasificacion, string Codigo, string Descripcion)
        {
            Entity.ValClasificacionResult_ regreso = JsonConvert.DeserializeObject<Entity.ValClasificacionResult_>(methodPost("ValClasificacion/" + IdClasificacion.ToString() + "/" + Codigo + "/" + Descripcion));
            return regreso.ValClasificacionResult;
        }

        public int DelClasificacionSelected(int IdUser, string Valores)
        {
            Entity.DelClasificacionSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelClasificacionSelectedResult_>(methodPost("DelClasificacionSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelClasificacionSelectedResult;
        }

        public int DelClasificacionAll(int IdUser, bool Activo)
        {
            Entity.DelClasificacionAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelClasificacionAllResult_>(methodPost("DelClasificacionAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelClasificacionAllResult;
        }
    }
}