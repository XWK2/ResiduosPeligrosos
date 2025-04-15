using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetTipoEnvaseResult_
    {
        public List<TiposEnvase> GetTipoEnvaseResult { get; set; }
    }
    public class GetCmbTiposEnvaseResult_
    {
        public List<TiposEnvase> GetCmbTiposEnvaseResult { get; set; }
    }

    public class DelTiposEnvaseResult_
    {
        public int DelTiposEnvaseResult { get; set; }
    }
    public class InsTiposEnvaseResult_
    {
        public int InsTiposEnvaseResult { get; set; }
    }
    public class UpdTiposEnvaseResult_
    {
        public int UpdTiposEnvaseResult { get; set; }
    }
    public class ValTiposEnvaseResult_
    {
        public int ValTiposEnvaseResult { get; set; }
    }
    public class DelTiposEnvaseSelectedResult_
    {
        public int DelTiposEnvaseSelectedResult { get; set; }
    }
    public class DelTiposEnvaseAllResult_
    {
        public int DelTiposEnvaseAllResult { get; set; }
    }


    public class TiposEnvase
    {
        public int tipoEnvaseID { get; set; }
        public string Codigo { get; set; }
        public decimal capacidad { get; set; }
        public string material { get; set; }       
        public bool Activo { get; set; }
        public string CodigoYNombre { get; set; }
        public decimal pesoBruto { get; set; }
    }

    public class Expira
    {
        public string value { get; set; }
        public string text { get; set; }
    }

    public class ValoresDefault
    {
        public string value { get; set; }
        public string text { get; set; }
    }
}