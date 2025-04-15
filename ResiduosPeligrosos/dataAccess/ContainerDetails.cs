using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class ContainerDetailsDa : Base
    {
        public List<Entity.ContainerDetails> GetContainerDetails(string fechaIni, string fechaFin, string codigoTipoManifiesto, string codigoTipoResiduo)
        {
            string json = methodGet("GetContainerDetails/" + fechaIni + "/" + fechaFin + "/" + codigoTipoManifiesto + "/" + codigoTipoResiduo);
            Entity.GetContainerDetailsResult_ regreso = JsonConvert.DeserializeObject<Entity.GetContainerDetailsResult_>(json);
            return regreso.GetContainerDetailsResult;
        }

        public List<Entity.ContainerDetails> GetContainerDetailsxManifiestoId(string manifiestoId)
        {
            string json = methodGet("GetContainerDetailsxManifiestoId/" + manifiestoId);
            Entity.GetContainerDetailsxManifiestoIdResult_ regreso = JsonConvert.DeserializeObject<Entity.GetContainerDetailsxManifiestoIdResult_>(json);
            return regreso.GetContainerDetailsxManifiestoIdResult;
        }        
    }
}