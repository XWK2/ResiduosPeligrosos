using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class AltaMaterialDa : Base
    {
        public List<Entity.AltaMaterial> GetAltaMaterialxGaylordId(string GaylordId)
        {
            string json = methodGet("GetAltaMaterialxGaylordId/" + GaylordId);
            Entity.GetAltaMaterialxGaylordIdResult_ regreso = JsonConvert.DeserializeObject<Entity.GetAltaMaterialxGaylordIdResult_>(json);
            return regreso.GetAltaMaterialxGaylordIdResult;
        }

        public List<Entity.AltaMaterial> GetAltaMaterial(string fechaIni, string fechaFin, string codigoAlmacen, string codigoLocacion)
        {
            string json = methodGet("GetAltaMaterial/" + fechaIni + "/"+ fechaFin + "/" + codigoAlmacen + "/" + codigoLocacion);
            Entity.GetAltaMaterialResult_ regreso = JsonConvert.DeserializeObject<Entity.GetAltaMaterialResult_>(json);
            return regreso.GetAltaMaterialResult;
        }
    }
}