using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetRelacionGaylordsResult_
    {
        public List<RelacionGaylords> GetRelacionGaylordsResult { get; set; }
    }
    public class GetCmbRelacionGaylordsResult_
    {
        public List<RelacionGaylords> GetCmbRelacionGaylordsResult { get; set; }
    }
       
    public class InsRelacionGaylordsResult_
    {
        public int InsRelacionGaylordsResult { get; set; }
    }
    public class UpdRelacionGaylordsResult_
    {
        public int UpdRelacionGaylordsResult { get; set; }
    }
    public class ValRelacionGaylordsResult_
    {
        public int ValRelacionGaylordsResult { get; set; }
    }
    public class DelRelacionGaylordsSelectedResult_
    {
        public int DelRelacionGaylordsSelectedResult { get; set; }
    }
    public class DelRelacionGaylordsAllResult_
    {
        public int DelRelacionGaylordsAllResult { get; set; }
    }

    public class RelacionGaylords
    {        
        public int RelacionId { get; set; }   
        public string CodigoParte { get; set; }       
        public string Parte { get; set; }        
        public string numParteImportExport { get; set; }        
        public string CodigoResiduo { get; set; }       
        public string Residuo { get; set; }        
        public string CodigoTipoEnvase { get; set; }        
        public string TipoEnvase { get; set; }        
        public string expira { get; set; }        
        public int tiempoExpiracion { get; set; }        
        public string venta { get; set; }        
        public string etiqueta { get; set; }
    }
}