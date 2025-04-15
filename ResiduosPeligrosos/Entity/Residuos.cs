using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetResiduosResult_
    {
        public List<Residuos> GetResiduosResult { get; set; }
    }
    public class GetResiduosxIdsResult_
    {
        public List<Residuos> GetResiduosxIdsResult { get; set; }
    }
    public class GetCmbResiduosResult_
    {
        public List<Residuos> GetCmbResiduosResult { get; set; }
    }
    public class DelResiduosResult_
    {
        public int DelResiduosResult { get; set; }
    }
    public class InsResiduosResult_
    {
        public int InsResiduosResult { get; set; }
    }
    public class UpdResiduosResult_
    {
        public int UpdResiduosResult { get; set; }
    }
    public class ValResiduosResult_
    {
        public int ValResiduosResult { get; set; }
    }
    public class DelResiduosSelectedResult_
    {
        public int DelResiduosSelectedResult { get; set; }
    }
    public class DelResiduosAllResult_
    {
        public int DelResiduosAllResult { get; set; }
    }

    public class Residuos
    {        
        public string noDocumento { get; set; }
        public int ResiduoId { get; set; }        
        public string CodigoResiduo { get; set; }        
        public string Nombre { get; set; }        
        public string Clasificaciones { get; set; }        
        public string CodigoTipoManifiesto { get; set; }        
        public string TipoManifiesto { get; set; }        
        public string CodigoGrupo { get; set; }        
        public string Grupo { get; set; }        
        public string ValorizableConBeneficio { get; set; }        
        public string ValorizableConGasto { get; set; }        
        public string Tipo { get; set; }        
        public string CodigoYNombre { get; set; }

    }
}