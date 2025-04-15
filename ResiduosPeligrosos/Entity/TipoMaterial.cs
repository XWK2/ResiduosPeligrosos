using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace ResiduosPeligrosos.Entity
{
    public class GetTipoMaterialResult_
    {
        public List<TipoMaterial> GetTipoMaterialResult { get; set; }
    }
    public class GetCmbTipoMaterialResult_
    {
        public List<TipoMaterial> GetCmbTipoMaterialResult { get; set; }
    }

    public class DelTipoMaterialResult_
    {
        public int DelTipoMaterialResult { get; set; }
    }
    public class InsTipoMaterialResult_
    {
        public int InsTipoMaterialResult { get; set; }
    }
    public class UpdTipoMaterialResult_
    {
        public int UpdTipoMaterialResult { get; set; }
    }
    public class ValTipoMaterialResult_
    {
        public int ValTipoMaterialResult { get; set; }
    }
    public class DelTipoMaterialSelectedResult_
    {
        public int DelTipoMaterialSelectedResult { get; set; }
    }
    public class DelTipoMaterialAllResult_
    {
        public int DelTipoMaterialAllResult { get; set; }
    }

    public class TipoMaterial
    {
        public int TipoMaterialID { get; set; }   
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string CodigoYNombre { get; set; }
    }
}