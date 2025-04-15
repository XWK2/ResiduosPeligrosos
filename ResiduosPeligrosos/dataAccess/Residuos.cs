using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.IO;
using Newtonsoft.Json;

namespace ResiduosPeligrosos.dataAccess
{
    public class ResiduosDa : Base
    {
        public List<Entity.Residuos> GetCatalog(string Codigo, string Descripcion, bool Activo)
        {
            string json = methodGet("GetResiduos/" + Codigo + "/" + Descripcion + "/" + Activo.ToString());
            Entity.GetResiduosResult_ regreso = JsonConvert.DeserializeObject<Entity.GetResiduosResult_>(json);
            return regreso.GetResiduosResult;
        }

        public List<Entity.Residuos> GetResiduosxIds(string Ids)
        {
            string json = methodGet("GetResiduosxIds/" + Ids);
            Entity.GetResiduosxIdsResult_ regreso = JsonConvert.DeserializeObject<Entity.GetResiduosxIdsResult_>(json);
            return regreso.GetResiduosxIdsResult;
        }

        public List<Entity.Residuos> GetCombo()
        {
            string json = methodGet("GetCmbResiduos");
            Entity.GetCmbResiduosResult_ regreso = JsonConvert.DeserializeObject<Entity.GetCmbResiduosResult_>(json);
            return regreso.GetCmbResiduosResult;
        }         

        public int InsResiduos(int IdUser, string CodigoResiduo, string Nombre, string Clasificaciones, string CodigoTipoManifiesto, string CodigoGrupo, string ValorizableConBeneficio, string ValorizableConGasto, string Tipo)
        {
            Entity.Residuos util = new Entity.Residuos();
            util.CodigoResiduo = CodigoResiduo;
            util.Nombre = Nombre;
            util.Clasificaciones = Clasificaciones;
            util.CodigoTipoManifiesto = CodigoTipoManifiesto;
            util.CodigoGrupo = CodigoGrupo;
            util.ValorizableConBeneficio = ValorizableConBeneficio;
            util.ValorizableConGasto = ValorizableConGasto;
            util.Tipo = Tipo;
            
            Entity.InsResiduosResult_ regreso = JsonConvert.DeserializeObject<Entity.InsResiduosResult_>(methodPost("InsResiduos/" + IdUser.ToString(), JsonConvert.SerializeObject(util)));
            return regreso.InsResiduosResult;
        }

        public int UpdResiduos(int IdUser, int ResiduosId, string CodigoResiduo, string Nombre, string Clasificaciones, string CodigoTipoManifiesto, string CodigoGrupo, string ValorizableConBeneficio, string ValorizableConGasto, string Tipo)
        {
            Entity.Residuos util = new Entity.Residuos();
            util.ResiduoId = ResiduosId;
            util.CodigoResiduo = CodigoResiduo;
            util.Nombre = Nombre;
            util.Clasificaciones = Clasificaciones;
            util.CodigoTipoManifiesto = CodigoTipoManifiesto;
            util.CodigoGrupo = CodigoGrupo;
            util.ValorizableConBeneficio = ValorizableConBeneficio;
            util.ValorizableConGasto = ValorizableConGasto;
            util.Tipo = Tipo;

            Entity.UpdResiduosResult_ regreso = JsonConvert.DeserializeObject<Entity.UpdResiduosResult_>(methodPost("UpdResiduos/" + IdUser.ToString(), JsonConvert.SerializeObject(util)));
            return regreso.UpdResiduosResult;
        }

        public int ValResiduos(int IdResiduos, string Codigo, string Descripcion)
        {
            Entity.ValResiduosResult_ regreso = JsonConvert.DeserializeObject<Entity.ValResiduosResult_>(methodPost("ValResiduos/" + IdResiduos.ToString() + "/" + Codigo + "/" + Descripcion));
            return regreso.ValResiduosResult;
        }

        public int DelResiduosSelected(int IdUser, string Valores)
        {
            Entity.DelResiduosSelectedResult_ regreso = JsonConvert.DeserializeObject<Entity.DelResiduosSelectedResult_>(methodPost("DelResiduosSelected/" + IdUser.ToString() + "/" + Valores));
            return regreso.DelResiduosSelectedResult;
        }

        public int DelResiduosAll(int IdUser, bool Activo)
        {
            Entity.DelResiduosAllResult_ regreso = JsonConvert.DeserializeObject<Entity.DelResiduosAllResult_>(methodPost("DelResiduosAll/" + IdUser.ToString() + "/" + Activo.ToString()));
            return regreso.DelResiduosAllResult;
        }
    }
}