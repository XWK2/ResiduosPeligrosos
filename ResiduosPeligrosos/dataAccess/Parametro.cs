using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using Newtonsoft.Json;


namespace ResiduosPeligrosos.dataAccess
{
    public class ParametroDa : Base
    {
        public Entity.Parametro GetParametro(string Codigo)
        {
            string json = methodGet("GetParametro/" + Codigo);
            Entity.GetParametroResult_ regreso = JsonConvert.DeserializeObject<Entity.GetParametroResult_>(json);
            return regreso.GetParametroResult;
        }

        public List<Entity.Parametro> GetCatalog(string Descripcion)
        {
            string json = methodGet("GetParametros/" + Descripcion);
            Entity.GetParametrosResult_ regreso = JsonConvert.DeserializeObject<Entity.GetParametrosResult_>(json);
            return regreso.GetParametrosResult;
        }

        public int UpdParametro(int UsuarioId, int ParametroId, string Valor, bool bEncrypted)
        {
            Entity.Parametro Parametro = new Entity.Parametro();
            Parametro.ID = ParametroId;
            Parametro.Valor = Valor;

            Parametro.Clave = "";
            Parametro.ClaveYDescripcion = "";
            Parametro.Descripcion = "";
            Parametro.Padre = "";
            Parametro.Editable = false;
            Parametro.Encriptado = bEncrypted;            

            Entity.UpdParametroResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdParametroResult_>(methodPost("UpdParametro/" + UsuarioId.ToString(), JsonConvert.SerializeObject(Parametro)));
            return regreso.UpdParametroResult;
        }

    }
}