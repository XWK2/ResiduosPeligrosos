using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
   
        public class GetLocacionesResult_
        {
            public List<Locaciones> GetLocacionesResult { get; set; }
        }
        public class GetCmbLocacionResult_
        {
            public List<Locaciones> GetCmbLocacionResult { get; set; }
        }
        public class GetCmbLocacionbyalmacenResult_
        {
            public List<Locaciones> GetCmbLocacionbyalmacenResult { get; set; }
        }

        public class DelLocacionesResult_
        {
            public int DelLocacionesResult { get; set; }
        }
        public class InsLocacionesResult_
        {
            public int InsLocacionesResult { get; set; }
        }
        public class UpdLocacionesResult_
        {
            public int UpdLocacionesResult { get; set; }
        }
        public class ValLocacionesResult_
        {
            public int ValLocacionesResult { get; set; }
        }
        public class DelLocacionesSelectedResult_
        {
            public int DelLocacionesSelectedResult { get; set; }
        }
        public class DelLocacionesAllResult_
        {
            public int DelLocacionesAllResult { get; set; }
        }

        public class Locaciones
        {
            public int locacionId { get; set; }
            public string Codigo { get; set; }
            public string nombreLocacion { get; set; }
            public string codigoAlmacen { get; set; }
            public string almacen { get; set; }
            public string CodigoYNombre { get; set; }
            public bool Activo { get; set; }
        }
    
}