using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetAlmacenResult_
    {
        public List<Almacen> GetAlmacenResult { get; set; }
    }

    public class GetAlmacenxCodigoPlantaResult_
    {
        public List<Almacen> GetAlmacenxCodigoPlantaResult { get; set; }
    }

    public class GetCmbAlmacenResult_
    {
        public List<Almacen> GetCmbAlmacenResult { get; set; }
    }

    public class DelAlmacenResult_
    {
        public int DelAlmacenResult { get; set; }
    }
    public class InsAlmacenResult_
    {
        public int InsAlmacenResult { get; set; }
    }
    public class UpdAlmacenResult_
    {
        public int UpdAlmacenResult { get; set; }
    }
    public class ValAlmacenResult_
    {
        public int ValAlmacenResult { get; set; }
    }
    public class DelAlmacenSelectedResult_
    {
        public int DelAlmacenSelectedResult { get; set; }
    }
    public class DelAlmacenAllResult_
    {
        public int DelAlmacenAllResult { get; set; }
    }

    public class Almacen
    {
        public int almacenId { get; set; }
        public string Codigo { get; set; }
        public string nombreAlmacen { get; set; }
        public string codigoPlanta { get; set; }
        public string planta { get; set; }
        public string CodigoYNombre { get; set; }
        public bool Activo { get; set; }
    }
}