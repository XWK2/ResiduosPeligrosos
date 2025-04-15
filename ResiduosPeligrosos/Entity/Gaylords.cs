using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetGaylordsByDateResult_
    {
        public List<Gaylords> GetGaylordsByDateResult { get; set; }
    }

    public class GetGaylordsxIdsResult_
    {
        public List<Gaylords> GetGaylordsxIdsResult { get; set; }
    }

    public class Gaylords
    {
        public string noDocumento { get; set; }
        public int GaylordID { get; set; }        
        public string codigo { get; set; }        
        public string codigoTipoEnvase { get; set; }        
        public string codigoMaterial { get; set; }        
        public string codigoLocacion { get; set; }        
        public decimal capacidad { get; set; }        
        public string Material { get; set; }        
        public string locacion { get; set; }
        public string TipoEnvase { get; set; }
        public string clasificaciones { get; set; }
        public string IEDescripcion { get; set; }
        public string residuo { get; set; }
        public decimal peso { get; set; }
    }
}