using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetClasificacionResult_
    {
        public List<Clasificacion> GetClasificacionResult { get; set; }
    }
    public class GetCmbClasificacionResult_
    {
        public List<Clasificacion> GetCmbClasificacionResult { get; set; }
    }
       
    public class InsClasificacionResult_
    {
        public int InsClasificacionResult { get; set; }
    }
    public class UpdClasificacionResult_
    {
        public int UpdClasificacionResult { get; set; }
    }
    public class ValClasificacionResult_
    {
        public int ValClasificacionResult { get; set; }
    }
    public class DelClasificacionSelectedResult_
    {
        public int DelClasificacionSelectedResult { get; set; }
    }
    public class DelClasificacionAllResult_
    {
        public int DelClasificacionAllResult { get; set; }
    }

    public class Clasificacion
    {
        public int clasificacionId { get; set; }
        public string codigo { get; set; }
        public string nombre { get; set; }
        public string codigoyNombre { get; set; }
    }
}