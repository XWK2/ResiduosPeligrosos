using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;


namespace ResiduosPeligrosos.dataAccess
{
    public class PendigManifiestDa : Base
    {
        public List<Entity.pendingManifiest> GetPendingManifiest(string fechaIni, string fechaFin, string codigoTipoManifiesto, string codigoTipoResiduo)
        {
            string json = methodGet("GetPendingManifiest/" + fechaIni + "/" + fechaFin +  "/" + codigoTipoManifiesto + "/" + codigoTipoResiduo);
            Entity.GetPendingManifiestResult_ regreso = JsonConvert.DeserializeObject<Entity.GetPendingManifiestResult_>(json);
            return regreso.GetPendingManifiestResult;
        }
    }
}