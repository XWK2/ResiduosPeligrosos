using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class Manifiestoda : Base
    {
        public List<Entity.Manifiestos> GetManifiestos(string fechaini, string fechafin, string folio, string codigoTipoManifiesto, string codigoTipoResiduo)
        {
            string json = methodGet("GetManifiestos/" + fechaini + "/" + fechafin + "/" + folio + "/" + codigoTipoManifiesto + "/" + codigoTipoResiduo);
            Entity.GetManifiestosResult_ regreso = JsonConvert.DeserializeObject<Entity.GetManifiestosResult_>(json);
            return regreso.GetManifiestosResult;
        }

        public List<Entity.Manifiestos> GetManifiesto(string ManifiestoId)
        {
            string json = methodGet("GetManifiesto/" + ManifiestoId);
            Entity.GetManifiestoResult_ regreso = JsonConvert.DeserializeObject<Entity.GetManifiestoResult_>(json);
            return regreso.GetManifiestoResult;
        }

        public string GetConsecutivosolicitud()
        {
            string json = methodGet("GetConsecutivosolicitud");
            Entity.GetConsecutivosolicitudResult_ regreso = JsonConvert.DeserializeObject<Entity.GetConsecutivosolicitudResult_>(json);
            return regreso.GetConsecutivosolicitudResult;
        }

        public int InsManifiesto(Entity.Manifiestos Manifiesto, string UsuarioId)
        {
            int regreso = Convert.ToInt32(methodPost("InsManifiesto/" + UsuarioId, JsonConvert.SerializeObject(Manifiesto)));
            return regreso;
        }

        public int UpdManifiesto(Entity.Manifiestos Manifiesto, string UsuarioId)
        {
            int regreso = Convert.ToInt32(methodPost("UpdManifiesto/" + UsuarioId, JsonConvert.SerializeObject(Manifiesto)));
            return regreso;
        }

        public int UpdManifiestoEstatus(string NoDocumento, string Estatus, string UsuarioId)
        {
            int regreso = Convert.ToInt32(methodPost("UpdManifiestoEstatus/" + NoDocumento + "/"+ Estatus +  "/" + UsuarioId));
            return regreso;
        }
    }
}