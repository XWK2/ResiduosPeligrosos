using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class GaylordsDa: Base
    {
        public List<Entity.Gaylords> GetCatalog(string fechaini, string fechafin, string folio, string TipoManifiesto, string TipoResiduo)
        {
            string json = methodGet("GetGaylordsByDate/" + fechaini + "/" + fechafin + "/" + folio + "/"  + TipoManifiesto + "/" +  TipoResiduo);
            Entity.GetGaylordsByDateResult_ regreso = JsonConvert.DeserializeObject<Entity.GetGaylordsByDateResult_>(json);
            return regreso.GetGaylordsByDateResult;
        }

        public List<Entity.Gaylords> GetGaylordsxIds(string Ids)
        {
            string json = methodGet("GetGaylordsxIds/" + Ids);
            Entity.GetGaylordsxIdsResult_ regreso = JsonConvert.DeserializeObject<Entity.GetGaylordsxIdsResult_>(json);
            return regreso.GetGaylordsxIdsResult;
        }



    }
}