using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class AlmacenDa : Base
    {
        public List<Entity.Almacen> GetCatalog(string Codigo, bool Activo)
        {
            string json = methodGet("GetAlmacen/" + Codigo + "/" + Activo.ToString());
            Entity.GetAlmacenResult_ regreso = JsonConvert.DeserializeObject<Entity.GetAlmacenResult_>(json);
            return regreso.GetAlmacenResult;
        }

        public List<Entity.Almacen> GetAlmacenxCodigoPlanta(string CodigoPlanta, bool Activo)
        {
            string json = methodGet("GetAlmacenxCodigoPlanta/" + CodigoPlanta + "/" + Activo.ToString());
            Entity.GetAlmacenxCodigoPlantaResult_ regreso = JsonConvert.DeserializeObject<Entity.GetAlmacenxCodigoPlantaResult_>(json);
            return regreso.GetAlmacenxCodigoPlantaResult;
        }

        public List<Entity.Almacen> GetCombo()
        {
            string json = methodGet("GetCmbAlmacen");
            Entity.GetCmbAlmacenResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbAlmacenResult_>(json);
            return regreso.GetCmbAlmacenResult;
        }

        public int DelAlmacen(int IdUser, int IdAlmacen)
        {
            Entity.DelAlmacenResult_ regreso = JsonConvert.DeserializeObject<Entity.DelAlmacenResult_>(methodPost("DelAlmacen/" + IdUser.ToString() + "/" + IdAlmacen.ToString()));
            return regreso.DelAlmacenResult;
        }

        public int InsAlmacen(int IdUser, string Codigo, string nombreAlmacen, string codigoPlanta)
        {
            Entity.Almacen tAlmacen= new Entity.Almacen();
            tAlmacen.Codigo = Codigo;
            tAlmacen.nombreAlmacen = nombreAlmacen;
            tAlmacen.codigoPlanta = codigoPlanta;
            
            Entity.InsAlmacenResult_ regreso = JsonConvert.DeserializeObject<Entity.InsAlmacenResult_>(methodPost("InsAlmacen/" + IdUser.ToString(), JsonConvert.SerializeObject(tAlmacen)));
            return regreso.InsAlmacenResult;
        }

        public int UpdAlmacen(int IdUser, int almacenId, string Codigo, string nombreAlmacen, string codigoPlanta)
        {
            Entity.Almacen tAlmacen = new Entity.Almacen();
            tAlmacen.almacenId = almacenId;
            tAlmacen.Codigo = Codigo;
            tAlmacen.nombreAlmacen = nombreAlmacen;
            tAlmacen.codigoPlanta = codigoPlanta;           

            Entity.UpdTiposEnvaseResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdTiposEnvaseResult_>(methodPost("UpdTiposEnvase/" + IdUser.ToString(), JsonConvert.SerializeObject(tAlmacen)));
            return regreso.UpdTiposEnvaseResult;
        }

        public int ValAlmacen(int idAlmacen, string Codigo)
        {
            Entity.ValAlmacenResult_ regreso = JsonConvert.DeserializeObject<Entity.ValAlmacenResult_>(methodPost("ValAlmacen/" + idAlmacen.ToString() + "/" + Codigo));
            return regreso.ValAlmacenResult;
        }

        public int DelAlmacenSelected(int IdUser, string Valores)
        {
            Entity.DelAlmacenSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelAlmacenSelectedResult_>(methodPost("DelAlmacenSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelAlmacenSelectedResult;
        }

        public int DelAlmacenAll(int IdUser, bool Activo)
        {
            Entity.DelAlmacenAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelAlmacenAllResult_>(methodPost("DelAlmacenAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelAlmacenAllResult;
        }
    }
}